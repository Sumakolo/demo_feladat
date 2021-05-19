using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Models;


namespace Demo.Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public Employee AddOne(Employee item)
        {
            throw new NotImplementedException();
        }

        public void DeleteOne(Employee item)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
