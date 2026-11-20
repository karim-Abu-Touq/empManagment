namespace empManagment.Models
{
    public class clsDashboardViewModel
    {
        public int TotalEmployees { get; set; }

        public int TotalDepartments { get; set; }

        public int TotalPositions { get; set; }

        public int TotalRetiredEmployees { get; set; }

        public decimal TotalSalaries { get; set; }

        public decimal AverageSalary { get; set; }
        public Dictionary<string, int> EmployeesByDepartment { get; set; } = new Dictionary<string, int>();

        public Dictionary<string, decimal> SalariesByDepartment { get; set; } = new Dictionary<string, decimal>();
    }
}
