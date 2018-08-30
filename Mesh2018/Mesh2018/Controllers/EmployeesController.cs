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
        // GET: api/Employee
        [HttpGet]
        [Route("{id}")]
        public Employee Get(int id)
        {
            return new Employee { Id = 1, FirstName ="Kurt", LastName="Feeley", Address = "1 Main St.",  City="Indianapolis", State="IN", Zip="46210" };
        }
        
    }
}
