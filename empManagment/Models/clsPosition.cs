using System.ComponentModel.DataAnnotations;

namespace empManagment.Models
{
    public class clsPosition
    {
        [Key]
        public int PosID { get; set; }
        [Required]
        [MaxLength(100)]
        public string PosTitle { get; set; }=string.Empty;
        [Range(0,100000)]
        public decimal MinSalary{ get; set; }
        [Range(0, 100000)]
        public decimal MaxSalary { get; set; }
        public ICollection<clsEmployee> PosEmployees { get; set; } = new List<clsEmployee>();
        [Required]
        public int DepartmentID { get; set; }

        public clsDepartment? Departments { get; set; }

    }
}
