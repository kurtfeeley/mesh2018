using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mesh2018.Models
{
    public class Employee
    {
        /// <summary>
        /// The unique identifier of the employee.
        /// </summary>
        /// <example>1</example>
        public int Id { get; set; }

        /// <summary>
        /// The first name of the employee.
        /// </summary>
        /// <example>Kurt</example>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the employee.
        /// </summary>
        /// <example>Feeley</example>
        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }
    }
}
