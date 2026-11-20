using empManagment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace empManagment.Controllers
{
    [Authorize]
    public class RetiredEmployeesController : Controller
    {
        private readonly IRepository<clsRetiredEmployee> _RetiredEmployeeRepository;

        public RetiredEmployeesController(IRepository<clsRetiredEmployee> RetiredEmployeeRepository)
        {
            _RetiredEmployeeRepository = RetiredEmployeeRepository;
        }
        public IActionResult Index(int page=1)
        {
            int PageSize = 9;
            int TotalRetiredEmployees = _RetiredEmployeeRepository.Count();
            int TotalPages = (int)Math.Ceiling((double)TotalRetiredEmployees / PageSize);
            var retiredEmp= _RetiredEmployeeRepository.GetAll(PageSize,page,e=>e.Department,e=>e.Position);
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = TotalPages;
            ViewBag.TotalRetierdEmployees = TotalRetiredEmployees;
            return View(retiredEmp);
        }

      
    }
}
