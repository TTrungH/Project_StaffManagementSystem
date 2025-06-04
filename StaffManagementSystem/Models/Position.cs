using System.ComponentModel.DataAnnotations;

namespace StaffManagementSystem.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "Title must not exceed 100 characters.")]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        public string? Description { get; set; }

        public  ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }

}
