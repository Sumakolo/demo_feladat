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
        public void Create(string userName, string password1, string password2)
        {
            if (PasswordCheck(password1, password2))
            {
                Employee employee = new Employee();
                employee.EmpUserName = userName;
                employee.EmpPassword = password1;
                employeeRepository.AddOne(employee);
            }    
            
        }

        /// <summary>
        /// Delete an employee item from the database by it's ID.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            employeeRepository.DeleteOneByID(id);
        }

        /// <summary>
        /// Returns all employees from the database.
        /// </summary>
        /// <returns>IList<Employee></returns>
        public IList<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }

        /// <summary>
        /// Get an employee by it's name, if the password is correct.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Employee</returns>
        public Employee GetEmployee(string name, string password)
        {
            Employee emp = employeeRepository.GetOneByName(name);
            if (emp.EmpPassword == password)
            {
                return emp;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Update an employee item.
        /// </summary>
        /// <param name="oldid"></param>
        /// <param name="newitem"></param>
        public void Update(int oldid, Employee newitem)
        {
            employeeRepository.Update(oldid, newitem);
        }

        /// <summary>
        /// Returns the employees data from the database as a string.
        /// </summary>
        /// <returns>StringBuilder</returns>
        public StringBuilder GetEmployeeData()
        {
            return employeeRepository.GetTableContents();
        }

        /// <summary>
        /// Check if the same password has been given during the registration.
        /// </summary>
        /// <param name="password1"></param>
        /// <param name="password2"></param>
        /// <returns>bool</returns>
        public bool PasswordCheck(string password1, string password2)
        {
            return (password1 == password2);
        }
    }
}
