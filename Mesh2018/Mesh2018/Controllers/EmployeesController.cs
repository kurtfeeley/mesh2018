using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mesh2018.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mesh2018.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/Employees/id
        [HttpGet("{id}")]        
        [ProducesResponseType(typeof(Employee), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult Get(int id)
        {
            //param validation
            if (id > 1) {
                return BadRequest();
            }

            var employee = new Employee { Id = 1, FirstName = "Kurt", LastName = "Feeley", Address = "1 Main St.", City = "Indianapolis", State = "IN", Zip = "46210" };

            return Ok(employee);
        }
        
    }
}
