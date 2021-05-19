using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Data;

namespace Demo.Repository
{
    class TaskRepository : IRepository<Data.Task>
    {
        DemoDBContext demoDBContext;

        /// <summary>
        /// Add one task to the database.
        /// </summary>
        /// <param name="item"></param>
        public void AddOne(Data.Task item)
        {
            demoDBContext.tasks.Add(item);
        }

        /// <summary>
        /// Delete one task from the database.
        /// </summary>
        /// <param name="item"></param>
        public void DeleteOne(Data.Task item)
        {
            demoDBContext.tasks.Remove(item);
        }

        /// <summary>
        /// Returns all tasks from the database.
        /// </summary>
        /// <returns>IList<Data.Task></returns>
        public IList<Data.Task> GetAll()
        {
            return demoDBContext.tasks.ToList();
        }

        /// <summary>
        /// Returns one task from the database by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Data.Task</returns>
        public Data.Task GetOneByName(string name)
        {
            return demoDBContext.tasks.FirstOrDefault(item => item.TaskName == name);
        }
    }
}
