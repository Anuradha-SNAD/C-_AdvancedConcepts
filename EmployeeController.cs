using EmployeeAPI.DTO;
using EmployeeAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService service;

        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }


        //[HttpGet]
        //public string Get()
        //{
        //    return "Hello Employee API";
        //}

        [HttpGet("{id}")]//Route parameter
        public string GetById(int id)
        {
            return $"Employee Id = {id}";
        }

        [HttpGet("search")]//Query Parameter
        public string Search(string name)
        {
            return $"Searching {name}";
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            return Ok(employee);
        }

        [HttpGet]
        public IActionResult Get()
        {
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Anu",
                Salary = 50000,
                Password = "abc123"

            };
            EmployeeDTO dto = new EmployeeDTO()
            {
                Id = emp.Id,
                Name = emp.Name,
                Salary = emp.Salary
            };
            return Ok(dto);
        }
        



    }
}
