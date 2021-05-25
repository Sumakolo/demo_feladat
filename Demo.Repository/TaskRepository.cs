using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.Data;

namespace Demo.Repository
{
    public class TaskRepository : IRepository<Task>
    {
        DemoDBEntities1 demoDBContext = new DemoDBEntities1();

        /// <summary>
        /// Add one task to the database.
        /// </summary>
        /// <param name="item"></param>
        public void AddOne(Task item)
        {
            demoDBContext.Tasks.Add(item);
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Delete ont task from the database by it's id.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteOneByID(int id)
        {
            Task task = demoDBContext.Tasks.FirstOrDefault(item => item.TaskID == id);
            demoDBContext.Tasks.Remove(task);
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Returns all tasks from the database.
        /// </summary>
        /// <returns>IList<Data.Task></returns>
        public IList<Task> GetAll()
        {
            return demoDBContext.Tasks.ToList();
        }

        /// <summary>
        /// Returns one task from the database by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Data.Task</returns>
        public Task GetOneByName(string name)
        {
            return demoDBContext.Tasks.FirstOrDefault(item => item.TaskName == name);
        }

        /// <summary>
        /// Update the properties of a Task.
        /// </summary>
        /// <param name="oldID"></param>
        /// <param name="newItem"></param>
        public void Update(int oldID, Task newItem)
        {
            var oldItem = demoDBContext.Tasks.FirstOrDefault(item => item.TaskID == oldID);
            oldItem.TaskID = newItem.TaskID;
            oldItem.TaskName = newItem.TaskName;
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Returns the repository as a string.
        /// </summary>
        /// <returns>StringBuilder</returns>
        public StringBuilder GetTableContents()
        {
            List<Task> tasks = GetAll().ToList();
            StringBuilder builder = new StringBuilder();
            foreach(var x in tasks)
            {
                builder.AppendLine("TaskID:" + x.TaskID + " | TaskName: " + x.TaskName);
            }
            return builder;
        }

        
    }
}
