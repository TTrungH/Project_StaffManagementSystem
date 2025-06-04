
using System.ComponentModel.DataAnnotations;
using StaffManagementSystem.Enums;


namespace StaffManagementSystem.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Username is not exceed 50 characters")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string PasswordHash { get; set; }
        public Role Role { get; set; }
        public int EmployeeId { get; set; }

        public  Employee Employee { get; set; }
    }   
}