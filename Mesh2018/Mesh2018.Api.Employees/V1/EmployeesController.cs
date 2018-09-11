﻿using Mesh2018.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace Mesh2018.Api.Employees.V1
{
    [ApiController]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class EmployeesController : ControllerBase
    {
        // GET: api/Employees/id
        /// <summary>
        /// This endpoint returns an employee when given an employee id.
        /// </summary>
        /// <param name="id">The unique identifier of the employee</param>
        /// <returns>Employee</returns>
        /// <remarks>Remarks are turned into Implementaion notes in swagger.</remarks>
        /// <response code="200">Employee fetched.</response>
        /// <response code="400">Invalid unique identifier (id) provided.</response>
        /// <response code="500">Something went wrong at the server.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Employee), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult Get(int id)
        {
            //param validation
            if (id > 1)
            {
                return BadRequest();
            }

            var employee = new Employee { Id = 1, FirstName = "Kurt", LastName = "Feeley", Address = "1 Main St.", City = "Indianapolis", State = "IN", Zip = "46210" };

            return Ok(employee);
        }

        /// <summary>
        /// Changes an Employees First Name
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="newFirstName"></param>
        /// <returns>Employee</returns>
        [HttpGet("ChangeFirstName")]
        [ProducesResponseType(typeof(Employee), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult ChangeFirstName([FromQuery] Employee employee, [FromQuery, BindRequired] string newFirstName)
        {
            //param validation
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            employee.FirstName = newFirstName;

            return Ok(employee);
        }   
    }
}
