namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;
    
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }


        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>() {
            new Employee() {
                Id = "21",
                Name = "Mette Bangsbo",
                Email = "meba@ibas.dk",
                Department = new Department() {
                    Id = 1,
                    Name = "Salg"
                }
            },
            new Employee() {
                Id = "22",
                Name = "Hans Merkel",
                Email = "hame@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "23",
                Name = "Karsten Mikkelsen",
                Email = "kami@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "24",
                Name = "Oskar Vesterbaek",
                Email = "osk@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "IT"
                }
            },
            new Employee() {
                Id = "25",
                Name = "pakiza",
                Email = "piki@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "IT"
                }
            },
            new Employee() {
                Id = "26",
                Name = "Sigurd",
                Email = "sigi@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "IT"
                }
            }
            
        };
            return employees;
        }
    }


}