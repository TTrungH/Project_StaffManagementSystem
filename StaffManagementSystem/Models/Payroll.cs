using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaffManagementSystem.Models
{
    public class Payroll
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee Id is required")]
        public int EmployeeId { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Period Start is required")]
        public DateTime PeriodStart { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Period End is required")]
        public DateTime PeriodEnd { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Period End is required")]
        public decimal GrossSalary { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Period End is required")]
        public decimal Tax { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Period End is required")]
        public decimal NetSalary { get; set; }

        public virtual Employee Employee { get; set; }
    }

}
