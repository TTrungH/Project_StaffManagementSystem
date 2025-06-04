using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StaffManagementSystem.Enums;

namespace StaffManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "First name must not exceed 50 characters.")]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "First name must not exceed 50 characters.")]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender is requied")]
        public Gender Gender { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date of birth is requied")]

        public DateOnly DateOfBirth { get; set; }

        [StringLength(150, ErrorMessage = "Email is not exceed 100 characters")]
        [EmailAddress(ErrorMessage = "Email is invalid format")]
        public string? Email { get; set; }

        [StringLength(10, ErrorMessage = "Phone number must not exceed 10 characters.")]
        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Hire Date is required")]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "Department Id is required")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Position Id is required")]

        public int PositionId { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 9999999999999.99)]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "Salary is required")]
        public decimal Salary { get; set; }

        public int? ManagerId { get; set; }

        //set relationship
        public  Department Department { get; set; }
        public  Position Position { get; set; }
        public  Employee? Manager { get; set; }
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
        public ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();
        public ICollection<PerformanceReview> PerformanceReviews { get; set; } = new List<PerformanceReview>();
        public ICollection<Adjustment> Adjustments { get; set; } = new List<Adjustment>();
        public  User User { get; set; }
    }
}
