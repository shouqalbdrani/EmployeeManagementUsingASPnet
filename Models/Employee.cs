using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; } = string.Empty; // Ensures no null values

        [Required(ErrorMessage = "Position is required")]
        [StringLength(50, ErrorMessage = "Position cannot exceed 50 characters")]
        [Column(TypeName = "VARCHAR(50)")] // Ensures MySQL stores it correctly
        public string Position { get; set; } = string.Empty;

        [Required(ErrorMessage = "Salary is required")]
        [Range(1, 1000000, ErrorMessage = "Salary must be between 1 and 1,000,000")]
        [Column(TypeName = "DECIMAL(18,2)")] 
        public decimal Salary { get; set; }
    }
}
