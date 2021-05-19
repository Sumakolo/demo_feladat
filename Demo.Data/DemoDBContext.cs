using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data
{
    public class DemoDBContext : DbContext
    {
        /// <summary>
        /// Contstructor for the DBContext.
        /// </summary>
        public DemoDBContext()
        {

        }

        /// <summary>
        /// DBSet for tasks.
        /// </summary>
        public DbSet<Task> tasks { get; set; }

        /// <summary>
        /// DBSet for employees.
        /// </summary>
        public DbSet<Employee> employees { get; set; }

        /// <summary>
        /// DBSet for activites.
        /// </summary>
        public DbSet<Activity> activities { get; set; }
    }
}
