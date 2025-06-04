using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace StaffManagementSystem.Models
{
    public class Adjustment
    {
        [Key]
        public int AdjustmentId { get; set; }
       
        [Required]
        [Column(TypeName = "decimal(15,2)")]
        public decimal Amount { get; set; }
        [Required]

        public string Reason { get; set; }
        [Required]
        
        public DateOnly Date { get; set; }
        [Required]

        public AdjustmentType Type { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Notes { get; set; }

        //FK
        public int EmployeeId { get; set; }
        [Required]
        public virtual Employee Employee { get; set; }

    }
    public enum AdjustmentType
    {
        Bonus, Penalty
    }
}
