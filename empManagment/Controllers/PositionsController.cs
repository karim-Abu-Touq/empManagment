using empManagment.Models;
using empManagment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace empManagment.Controllers
{
    [Authorize]
    public class PositionsController : Controller
    {
        private readonly IRepository<clsPosition> _clsPositionRepository;
        private readonly IRepository<clsDepartment> _clsDepartmentRepository;
        private readonly IRepository<clsEmployee> _clsEmployeeRepository;

        public PositionsController(IRepository<clsPosition> clsPositionRepository, IRepository<clsDepartment> clsDepartmentRepository,
            IRepository<clsEmployee> clsEmployeeRepository)
        {
            _clsPositionRepository = clsPositionRepository;
            _clsDepartmentRepository = clsDepartmentRepository;
            _clsEmployeeRepository = clsEmployeeRepository;
        }
        public IActionResult Index(int page=1)
        {
            int PageSize = 9;
            int TotalPositions=_clsPositionRepository.Count();
            int TotalPages = (int)Math.Ceiling((double)TotalPositions / PageSize);
            var Positions=_clsPositionRepository.GetAll(PageSize,page,e=>e.PosEmployees,e=>e.Departments);
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = TotalPages;
            ViewBag.TotalPositions=TotalPositions;
            ViewBag.Departments = _clsDepartmentRepository.GetAll();
            return View(Positions);
        }

        public IActionResult Create()
        {
            var Departments = _clsDepartmentRepository.GetAll();
            ViewBag.Departments = Departments;
            return View();  
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(clsPosition position)
        {
            if (ModelState.IsValid)
            {
                _clsPositionRepository.Add(position);
                _clsPositionRepository.Save();
                TempData["Success"] = "Position Created successfully";
                return RedirectToAction("Index");
            }
            ViewBag.Departments = _clsDepartmentRepository.GetAll();
            return View(position);
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(clsPosition position) 
        { 
            if(ModelState.IsValid)
            {
                _clsPositionRepository.Update(position);
                _clsPositionRepository.Save();
                TempData["Success"] = "Position updated successfully";
                return RedirectToAction("Index");
            }
            ViewBag.Departments = _clsDepartmentRepository.GetAll();
            return View(position);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Remove")]
        public IActionResult RemoveConfirm(int id)
        {
            clsPosition? position = _clsPositionRepository.Get(e => e.PosID == id, e => e.PosEmployees);

            if(position == null) { return NotFound(); }

            if (position.PosEmployees.Any())
            {
               TempData["Error"] = $"Cannot delete {position.PosTitle} Position because it has employees. " +
                    $"Please move or remove all employees from this Position first.";
                return RedirectToAction("Index");
            }
            
            _clsPositionRepository.Remove(position);
            _clsPositionRepository.Save();
            TempData["Success"] = "Position deleted successfully";
            return RedirectToAction("Index");

        }
        public IActionResult PosEmployees(int id)
        {
            var Employees=_clsEmployeeRepository.GetAll(e=>e.Department,e=>e.Position).Where(e=>e.PositionID==id).ToList();
            var Position=_clsPositionRepository.Get(e=>e.PosID==id,e=>e.Departments);
            ViewBag.Position=Position;
            ViewBag.Department = Position?.Departments;

          
            return View(Employees);
        }

    }
}
