using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Repository;
using Demo.Data;

namespace Demo.Logic
{
    public class EmployeeLogic : ILogic<Employee>
    {
        EmployeeRepository employeeRepository;

        /// <summary>
        /// Constructor for the EmplpoyeeLogic class.
        /// </summary>
        /// <param name="employeeRepository"></param>
        public EmployeeLogic(EmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        /// <summary>
        /// Add a new employee item to the database.
        /// </summary>
        /// <param name="item"></param>
        public void Create(Employee item)
        {
            employeeRepository.AddOne(item);
        }

        /// <summary>
        /// Delete an employee item from the database.
        /// </summary>
        /// <param name="item"></param>
        public void Delete(Employee item)
        {
            employeeRepository.DeleteOne(item);
        }

        /// <summary>
        /// Delete an employee item from the database by it's ID.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            employeeRepository.DeleteOneByID(id);
        }

        /// <summary>
        /// Returns all employees from the database.
        /// </summary>
        /// <returns></returns>
        public IList<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }

        /// <summary>
        /// Update an employee item.
        /// </summary>
        /// <param name="oldid"></param>
        /// <param name="newitem"></param>
        public void Update(string oldid, Employee newitem)
        {
            employeeRepository.Update(oldid, newitem);
        }

        /// <summary>
        /// Returns the employees data from the database as a string.
        /// </summary>
        /// <returns></returns>
        public StringBuilder GetEmployeeData()
        {
            return employeeRepository.GetTableContents();
        }
    }
}
