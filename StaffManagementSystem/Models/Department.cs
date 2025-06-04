using System.ComponentModel.DataAnnotations;

namespace StaffManagementSystem.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100, ErrorMessage ="Department Name is not exceed 100 characters.")]
        [Required(ErrorMessage ="Department Name is required.")]
        public string DepartmentName { get; set; }
     
        [StringLength(100, ErrorMessage ="Location is not exceed 100 characters.")]
        public string? Location { get; set; }
        public int ManagerId { get; set; }

        public  Employee Manager { get; set; }
        public  ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
