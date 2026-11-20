using System.ComponentModel.DataAnnotations;

namespace empManagment.Models
{
    public class clsDepartment
    {
        [Key]
        public int DepID { get; set; }

        [Required]
        [MaxLength(100)]
        public string DepName { get; set; }=string.Empty;

        [MaxLength(500)]
        public string? Description { get; set; }= string.Empty;
        public ICollection<clsEmployee> DepEmployees { get; set; } = new List<clsEmployee>();
        public ICollection<clsPosition> DepPositions { get; set; }= new List<clsPosition>();

    }
}
