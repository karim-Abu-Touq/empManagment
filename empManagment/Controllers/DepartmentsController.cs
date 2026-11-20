using empManagment.Models;
using empManagment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace empManagment.Controllers
{
    [Authorize]
    public class DepartmentsController : Controller
    {
        private readonly IRepository<clsDepartment> _clsDepartmentRepository;
        private readonly IRepository<clsPosition> _clsPositionRepository;
        private readonly IRepository<clsEmployee> _clsEmployeeRepository;

        public DepartmentsController(IRepository<clsDepartment> clsDepartmentRepository, IRepository<clsPosition> clsPositionRepository,
            IRepository<clsEmployee> clsEmployeeRepository)
        {
            _clsDepartmentRepository = clsDepartmentRepository;
            _clsPositionRepository = clsPositionRepository;
            _clsEmployeeRepository = clsEmployeeRepository;
        }
        public IActionResult Index(int page=1)
        {
            int PageSize = 5;
            int TotalDepartments = _clsDepartmentRepository.Count();
            int TotalPages = (int)Math.Ceiling((double)TotalDepartments / PageSize);
            IEnumerable<clsDepartment> Departments= _clsDepartmentRepository.GetAll(PageSize,page,e=>e.DepEmployees,e=>e.DepPositions);
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = TotalPages;
            ViewBag.TotalDepartments= TotalDepartments;
            return View(Departments);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(clsDepartment Department)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrWhiteSpace(Department.Description))
                    Department.Description = "---";
                _clsDepartmentRepository.Add(Department);
                _clsDepartmentRepository.Save();
                TempData["Success"] = "Department created successfully";
                return RedirectToAction("Index");
            }
            return View(Department);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(clsDepartment Department)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrWhiteSpace(Department.Description))
                    Department.Description = "---";
                _clsDepartmentRepository.Update(Department);
                _clsDepartmentRepository.Save();
                TempData["Success"] = "Department updated successfully";
                return RedirectToAction("Index");
            }
            return View(Department);
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Remove")]
        public IActionResult RemoveConfirmed(int id)
        {
            clsDepartment? department = _clsDepartmentRepository.Get(e => e.DepID == id,e=>e.DepEmployees);
            if (department == null)
                return NotFound();
            if (department.DepEmployees.Any())
            {
                TempData["Error"] = $"Cannot delete {department.DepName} department because it has employees. Please move or remove all employees from this department first.";
                return RedirectToAction("Index");
            }
            _clsDepartmentRepository.Remove(department);
            _clsDepartmentRepository.Save();
            TempData["Success"] = "Department deleted successfully";
            return RedirectToAction("Index");

        }

        public IActionResult DepPositions(int id)
        {
            var Positions = _clsPositionRepository.GetAll(e=>e.PosEmployees).Where(e => e.DepartmentID == id).ToList();
            ViewBag.Department = _clsDepartmentRepository.Get(e => e.DepID == id);
            return View(Positions);
        }

        public IActionResult DepEmployees(int id)
        {
            var Employees = _clsEmployeeRepository.GetAll(e => e.Department, e => e.Position).Where(e => e.DepartmentID == id).ToList();
            ViewBag.Department = _clsDepartmentRepository.Get(e => e.DepID == id);
            return View(Employees);
        }

    }
}
