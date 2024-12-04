using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int id { get; set; }
        
        [Required(ErrorMessage = "First Name is required")] 
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Phone number is required")]
        [Length(9, 13)]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Position is required")]
        public string Position { get; set; }
    }
}
