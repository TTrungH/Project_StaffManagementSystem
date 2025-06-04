using System.ComponentModel.DataAnnotations;
using StaffManagementSystem.Enums;

namespace StaffManagementSystem.Models
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee Id is required")]
        public int EmployeeId { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Date is required")]
        public DateTime CheckIn { get; set; }
       
        [DataType(DataType.DateTime)]
        public DateTime? CheckOut { get; set; }
        public AttendanceStatus Status { get; set; }

        public virtual Employee Employee { get; set; }

    }

}
