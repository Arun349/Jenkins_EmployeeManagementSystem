using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Employee_Management_System.Models;

namespace Employee_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<EmployeeModel> employees = new List<EmployeeModel> { };

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<EmployeeModel> Getemployees()
        {
            return employees;
        }

        [HttpPost]
        public IActionResult Postemployees(EmployeeModel employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }
    }

}

