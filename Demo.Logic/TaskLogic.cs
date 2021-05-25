using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.Repository;
using Demo.Data;

namespace Demo.Logic
{
    public class TaskLogic : ILogic<Task>
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
        public void Create(Task item)
        {
            taskRepository.AddOne(item);
        }

        /// <summary>
        /// Delete a Task item from the database by it's ID.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            taskRepository.DeleteOneByID(id);
        }

        /// <summary>
        /// Returns all Task items.
        /// </summary>
        /// <returns>IList<Task></returns>
        public IList<Task> GetAll()
        {
            return taskRepository.GetAll();
        }

        /// <summary>
        /// Update a Task item.
        /// </summary>
        /// <param name="oldID"></param>
        /// <param name="newitem"></param>
        public void Update(int oldID, Task newitem)
        {
            taskRepository.Update(oldID, newitem);
        }

        /// <summary>
        /// Returns the data from the Task database as a string.
        /// </summary>
        /// <returns>StringBuilder</returns>
        public StringBuilder GetTaskData()
        {
            return taskRepository.GetTableContents();
        }
    }
}
