using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace empManagment.Models
{
    public class clsEmployee
    {
        [Key]
        public int EmpID { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }=string.Empty;
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }= string.Empty;
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;
        [Phone]
        [MaxLength (20)]
        public string? Phone { get; set; }
        [Range(0,100000)]
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        [Required]
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public clsDepartment? Department { get; set; }

        //Pos
        [Required]
        [ForeignKey("Position")]
        public int PositionID {  get; set; }
        public clsPosition? Position { get; set; } 
    }
}
