using empManagment.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class clsRetiredEmployee
{
    [Key]
    public int RetiredEmployeeID { get; set; }

    public int OriginalEmpID { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;

    [Phone]
    [MaxLength(20)]
    public string? Phone { get; set; }

    public decimal Salary { get; set; }

    public DateTime HireDate { get; set; }

    public int DepartmentID { get; set; }
    public clsDepartment? Department { get; set; }

    public int PositionID { get; set; }
    public clsPosition? Position {  get; set; }

    public DateTime RetirementDate { get; set; }

    [NotMapped]
    public string TotalService
    {
        get
        {
            int years = RetirementDate.Year - HireDate.Year;

            if (HireDate.AddYears(years) > RetirementDate)
                years--;

            int months = RetirementDate.Month - HireDate.AddYears(years).Month;

            if (months < 0)
                months += 12;

            return $"{years} Years, {months} Months";
        }
    }
}