using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Controllers
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1000,100000)]
        public decimal Salary { get; set; }
        [Required]
        public string Password { get; set; }
    }
}