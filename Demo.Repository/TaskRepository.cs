using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Data;

namespace Demo.Repository
{
    public class TaskRepository : IRepository<Data.Task>
    {
        DemoDBContext demoDBContext = new DemoDBContext();

        /// <summary>
        /// Add one task to the database.
        /// </summary>
        /// <param name="item"></param>
        public void AddOne(Data.Task item)
        {
            demoDBContext.tasks.Add(item);
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Delete one task from the database.
        /// </summary>
        /// <param name="item"></param>
        public void DeleteOne(Data.Task item)
        {
            demoDBContext.tasks.Remove(item);
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Delete ont task from the database by it's id.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteOneByID(string id)
        {
            Data.Task task = demoDBContext.tasks.FirstOrDefault(item => item.TaskID == id);
            DeleteOne(task);
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

        /// <summary>
        /// Update the properties of a Task.
        /// </summary>
        /// <param name="oldID"></param>
        /// <param name="newItem"></param>
        public void Update(string oldID, Data.Task newItem)
        {
            var oldItem = demoDBContext.tasks.FirstOrDefault(item => item.TaskID == oldID);
            oldItem.TaskID = newItem.TaskID;
            oldItem.TaskName = newItem.TaskName;
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Returns the repository as a string.
        /// </summary>
        /// <returns>StringBuilder.</returns>
        public StringBuilder GetTableContents()
        {
            List<Data.Task> tasks = GetAll().ToList();
            StringBuilder builder = new StringBuilder();
            foreach(var x in tasks)
            {
                builder.AppendLine("TaskID:" + x.TaskID + " | TaskName: " + x.TaskName);
            }
            return builder;
        }

        
    }
}
