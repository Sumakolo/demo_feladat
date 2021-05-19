using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Activity
    {
        /// <summary>
        /// The ID of the activity.
        /// </summary>
        public string ActID { get; set; }

        /// <summary>
        /// The date of the activity.
        /// </summary>
        public DateTime ActDate { get; set; }
        /// <summary>
        /// The ID of the employee.
        /// </summary>
        public string EmpName { get; set; }

        /// <summary>
        /// The ID of the task.
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// The time of the activity in hours.
        /// </summary>
        public int ActTimeHours { get; set; }

        /// <summary>
        /// The time the activity used up in minutes.
        /// </summary>
        public int ActTimeMinutes { get; set; }

        /// <summary>
        /// The description of the activity.
        /// </summary>
        public string ActDescription { get; set; }
    }
}
