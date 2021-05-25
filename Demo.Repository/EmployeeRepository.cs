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
        DemoDBEntities1 demoDBContext = new DemoDBEntities1();

        /// <summary>
        /// Add one employee to the database.
        /// </summary>
        /// <param name="item"></param>
        public void AddOne(Employee item)
        {
            demoDBContext.Employees.Add(item);
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Delete ont employee from the database by it's id.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteOneByID(int id)
        {
            Employee emp = demoDBContext.Employees.FirstOrDefault(item => item.EmpID == id);
            demoDBContext.Employees.Remove(emp);
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Returns all employees from the database.
        /// </summary>
        /// <returns>IList<Employee></returns>
        public IList<Employee> GetAll()
        {
            return demoDBContext.Employees.ToList();
        }

        /// <summary>
        /// Returns one employee from the database by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Employee</returns>
        public Employee GetOneByName(string name)
        {
            return demoDBContext.Employees.FirstOrDefault(item => item.EmpUserName == name);
        }

        /// <summary>
        /// Updates an employee in the database.
        /// </summary>
        /// <param name="oldID"></param>
        /// <param name="newItem"></param>
        public void Update(int oldID, Employee newItem)
        {
            var oldItem = demoDBContext.Employees.FirstOrDefault(item => item.EmpID == oldID);
            oldItem.EmpID = newItem.EmpID;
            oldItem.EmpUserName = newItem.EmpUserName;
            oldItem.EmpPassword = newItem.EmpPassword;
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Returns the repository as a string.
        /// </summary>
        /// <returns>StringBuilder</returns>
        public StringBuilder GetTableContents()
        {
            List<Employee> employees = GetAll().ToList();
            StringBuilder builder = new StringBuilder();
            foreach (var x in employees)
            {
                builder.AppendLine("EmployeeID:" + x.EmpID + " | Name: " + x.EmpUserName + " | Password: " + x.EmpPassword);
            }
            return builder;
        }

        
    }
}
