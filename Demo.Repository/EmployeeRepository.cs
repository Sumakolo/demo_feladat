using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Data;


namespace Demo.Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        DemoDBContext demoDBContext;

        /// <summary>
        /// Add one employee to the database.
        /// </summary>
        /// <param name="item"></param>
        public void AddOne(Employee item)
        {
            demoDBContext.employees.Add(item);
        }

        /// <summary>
        /// Delete one employee from the database.
        /// </summary>
        /// <param name="item"></param>
        public void DeleteOne(Employee item)
        {
            demoDBContext.employees.Remove(item);
        }

        /// <summary>
        /// Returns all employees from the database.
        /// </summary>
        /// <returns>IList<Employee></returns>
        public IList<Employee> GetAll()
        {
            return demoDBContext.employees.ToList();
        }

        /// <summary>
        /// Returns one employee from the database by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Employee</returns>
        public Employee GetOneByName(string name)
        {
            return demoDBContext.employees.FirstOrDefault(item => item.EmpName == name);
        }
    }
}
