using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Repository;
using Demo.Data;

namespace Demo.Logic
{
    public class TaskLogic : ILogic<Data.Task>
    {
        TaskRepository taskRepository;

        /// <summary>
        /// Constructor for the TaskLogic class.
        /// </summary>
        /// <param name="taskRepository"></param>
        public TaskLogic(TaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        /// <summary>
        /// Add a new Task item to the database.
        /// </summary>
        /// <param name="item"></param>
        public void Create(Data.Task item)
        {
            taskRepository.AddOne(item);
        }

        /// <summary>
        /// Delete a Task item from the database.
        /// </summary>
        /// <param name="item"></param>
        public void Delete(Data.Task item)
        {
            taskRepository.DeleteOne(item);
        }

        /// <summary>
        /// Delete a Task item from the database by it's ID.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            taskRepository.DeleteOneByID(id);
        }

        /// <summary>
        /// Returns all Task items.
        /// </summary>
        /// <returns></returns>
        public IList<Data.Task> GetAll()
        {
            return taskRepository.GetAll();
        }

        /// <summary>
        /// Update a Task item.
        /// </summary>
        /// <param name="oldID"></param>
        /// <param name="newitem"></param>
        public void Update(string oldID, Data.Task newitem)
        {
            taskRepository.Update(oldID, newitem);
        }

        /// <summary>
        /// Returns the data from the Task database as a string.
        /// </summary>
        /// <returns></returns>
        public StringBuilder GetTaskData()
        {
            return taskRepository.GetTableContents();
        }
    }
}
