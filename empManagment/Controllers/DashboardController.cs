using empManagment.Models;

using empManagment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace empManagment.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IRepository<clsRetiredEmployee> _RetiredEmployeeRepository;
        private readonly IRepository<clsDepartment> _DepartmentRepository;
        private readonly IRepository<clsPosition> _PositionRepository;

        public DashboardController(IEmployeeRepository employeeRepository, 
            IRepository<clsRetiredEmployee> RetiredEmployeeRepository,
            IRepository<clsDepartment> DepartmentRepository,
            IRepository<clsPosition> PositionRepository)
        {
            _employeeRepository = employeeRepository;
            _RetiredEmployeeRepository= RetiredEmployeeRepository;
            _DepartmentRepository = DepartmentRepository;
            _PositionRepository = PositionRepository;
        }


        public IActionResult Index()
        {
            var employees = _employeeRepository.GetAll();

            var dashboard = new clsDashboardViewModel
            {
                TotalEmployees = employees.Count(),
                TotalRetiredEmployees = _RetiredEmployeeRepository.GetAll().Count(),
                TotalDepartments = _DepartmentRepository.GetAll().Count(),
                TotalPositions = _PositionRepository.GetAll().Count(),

                TotalSalaries = employees.Sum(e => e.Salary),
                AverageSalary = employees.Any() ? employees.Average(e => e.Salary) : 0,
                EmployeesByDepartment = employees .GroupBy(e => e.Department!.DepName).ToDictionary( g => g.Key, g => g.Count() ),
                SalariesByDepartment = employees.GroupBy(e => e.Department!.DepName).ToDictionary(g => g.Key, g => g.Sum(e => e.Salary))
            };

            return View(dashboard);
        }
    }
}
