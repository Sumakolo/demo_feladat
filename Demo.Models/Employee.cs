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
        public string EmpID { get; set; }

        /// <summary>
        /// The last name of the employee.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The first name of the employee.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// List about the employee's activities.
        /// </summary>
        public List<Activity> ActivityList { get; set; }
    }
}
