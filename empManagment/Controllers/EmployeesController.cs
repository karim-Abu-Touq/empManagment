using empManagment.Models;
using empManagment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace empManagment.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IRepository<clsDepartment> _clsDepartmentRepository;
        private readonly IRepository<clsPosition> _clsPositionRepository;
        private readonly IRepository<clsRetiredEmployee> _clsRetiredEmployeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository,
            IRepository<clsDepartment> clsDepartmentRepository, IRepository<clsPosition> clsPositionRepository,
            IRepository<clsRetiredEmployee> clsRetiredEmployeeRepository)
        {
            _employeeRepository = employeeRepository;
            _clsDepartmentRepository = clsDepartmentRepository;
            _clsPositionRepository = clsPositionRepository;
            _clsRetiredEmployeeRepository = clsRetiredEmployeeRepository;
        }
        public IActionResult Index(string?search,int?departmentID,int? positionID,int page=1)
        {
            int PageSize = 9;

            var employees = _employeeRepository.SearchandFilter(search, departmentID, positionID, page, PageSize);

            int TotalEmployees=_employeeRepository.CountSearchandFilter(search,departmentID,positionID);
            int TotalPages = (int)Math.Ceiling((double)TotalEmployees / PageSize);

            ViewBag.Departments = _clsDepartmentRepository.GetAll();
            ViewBag.Positions = _clsPositionRepository.GetAll(p => p.Departments);

            ViewBag.search = search;
            ViewBag.departmentID=departmentID;
            ViewBag.positionID=positionID;

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = TotalPages;
            ViewBag.TotalEmployees=TotalEmployees;

            if (TempData["ShowDetailsModal"] != null)
            {
                ViewBag.ShowDetailsModal = TempData["ShowDetailsModal"];
            }

            return View(employees);
        }

        public IActionResult Create()
        {
            ViewBag.Departments = _clsDepartmentRepository.GetAll();
            ViewBag.Positions = _clsPositionRepository.GetAll();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(clsEmployee employee)
        {
            clsPosition ?position = _clsPositionRepository.Get(p => p.PosID == employee.PositionID);
            if (position == null || position.DepartmentID != employee.DepartmentID)
            {
                ModelState.AddModelError(
                    "PositionID",
                    "The selected position does not belong to the selected department."
                );
            }
            if (position != null)
            {
                if (employee.Salary < position.MinSalary || employee.Salary > position.MaxSalary)
                {
                    ModelState.AddModelError("Salary", $"Salary must be between {position.MinSalary} and {position.MaxSalary}.");
                }
            }

            if (ModelState.IsValid)
            {
                _employeeRepository.Add(employee);
                _employeeRepository.Save();
                TempData["Success"] = "Employee added successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.Departments = _clsDepartmentRepository.GetAll();
                ViewBag.Positions = _clsPositionRepository.GetAll();
                return View();
            }

        }

 

        public IActionResult Update(int id)
        {
            clsEmployee ?employee = _employeeRepository.GetByIDWithDepandPos(id);
            if (employee == null) {
                return NotFound();
            }
            ViewBag.Departments = _clsDepartmentRepository.GetAll();
            ViewBag.Positions = _clsPositionRepository.GetAll();
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(clsEmployee employee)
        {
            clsPosition? position = _clsPositionRepository.Get(e => e.PosID == employee.PositionID);

            if (position != null)
            {
                if (employee.Salary < position.MinSalary || employee.Salary > position.MaxSalary)
                {
                    ModelState.AddModelError("Salary", $"Salary must be between {position.MinSalary} and {position.MaxSalary}.");
                }
            }

            if (ModelState.IsValid)
            {
                _employeeRepository.Update(employee);
                _employeeRepository.Save();
                TempData["Success"] = "Employee updated successfully";
                return RedirectToAction("Index");
            }
            ViewBag.Departments = _clsDepartmentRepository.GetAll();
            ViewBag.Positions = _clsPositionRepository.GetAll();
            return View(employee);

        }


     

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Remove")]
        public IActionResult RemoveConfirmed(int id)
        {
            clsEmployee ?employee = _employeeRepository.GetByIDWithDepandPos(id);

            if(employee == null) { return NotFound(); }

            clsRetiredEmployee reEmp = new clsRetiredEmployee()
            {
                OriginalEmpID = employee.EmpID,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Phone = employee.Phone,
                Salary = employee.Salary,
                HireDate = employee.HireDate,
                DepartmentID = employee.DepartmentID,
                Department=employee.Department,
                PositionID = employee.PositionID,
                Position=employee.Position,
                RetirementDate=DateTime.Now,
            };

            _clsRetiredEmployeeRepository.Add(reEmp);
            _employeeRepository.Remove(employee);
            _clsRetiredEmployeeRepository.Save();
            TempData["Success"] = "Employee deleted successfully, The Employee moved to retired employee";
            return RedirectToAction("Index");
        }

        public IActionResult Find(int id)
        {
            clsEmployee?employee=_employeeRepository.GetByIDWithDepandPos(id);
            if(employee == null)
            {
                TempData["Error"] = $"Employee with ID {id} was not found.";
                return RedirectToAction("Index");
            }
            TempData["ShowDetailsModal"] = employee.EmpID;

            return RedirectToAction("Index");
        }

    }


    }
