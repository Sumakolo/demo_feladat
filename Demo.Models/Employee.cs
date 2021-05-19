using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Employee
    {
        /// <summary>
        /// The ID for the employee.
        /// </summary>
        public string EmpID { get; set; } //primary key

        /// <summary>
        /// The employee's name.
        /// </summary>
        public string EmpName { get; set; }

        /// <summary>
        /// The employee's password.
        /// </summary>
        public string EmpPassword { get; set; }
    }
}
