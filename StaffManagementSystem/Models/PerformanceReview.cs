using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaffManagementSystem.Models
{
    public class PerformanceReview
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee Id is required")]
        public int EmployeeId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ReviewDate { get; set; }

        [Required]
        public int Score { get; set; }
        public string? Comments { get; set; }

        public virtual Employee Employee { get; set; }
    }

}
