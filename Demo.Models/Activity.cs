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
        /// The ID for an activity.
        /// </summary>
        public string ActID { get; set; }

        /// <summary>
        /// The name of the activity.
        /// </summary>
        public string ActName { get; set; }

        /// <summary>
        /// The time the activity used up in hours.
        /// </summary>
        public int ActTimeHours { get; set; }

        /// <summary>
        /// The time the activity used up in minutes
        /// </summary>
        public int ActTimeMinutes { get; set; }

        /// <summary>
        /// The description of the activity.
        /// </summary>
        public string ActDescription { get; set; }
    }
}
