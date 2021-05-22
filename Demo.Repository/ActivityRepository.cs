using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.Data;

namespace Demo.Repository
{
    public class ActivityRepository : IRepository<Activity>
    {
        DemoDBEntities1 demoDBContext = new DemoDBEntities1();

        /// <summary>
        /// Add one activity to the database.
        /// </summary>
        /// <param name="item"></param>
        public void AddOne(Activity item)
        {
            demoDBContext.Activities.Add(item);
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Delete one activity from the database.
        /// </summary>
        /// <param name="item"></param>
        //public void DeleteOne(Activity item)
        //{
        //    demoDBContext.Activities.Remove(item);
        //    demoDBContext.SaveChanges();
        //}

        /// <summary>
        /// Delete one activity from the database by id.
        /// </summary>
        /// <param name="item"></param>
        public void DeleteOneByID(int id)
        {
            Activity activity = demoDBContext.Activities.FirstOrDefault(item => item.ActID == id);
            demoDBContext.Activities.Remove(activity);
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Returns all activities from the database.
        /// </summary>
        /// <returns></returns>
        public IList<Activity> GetAll()
        {
            return demoDBContext.Activities.ToList();
        }

        /// <summary>
        /// Returns an Activity by its ID.
        /// </summary>
        /// <param name="ActID"></param>
        /// <returns></returns>
        public Activity GetOneById(int ActID)
        {
            return demoDBContext.Activities.FirstOrDefault(item => item.ActID == ActID);
        }

        /// <summary>
        /// Updates an activity in the database.
        /// </summary>
        /// <param name="oldID"></param>
        /// <param name="newItem"></param>
        public void Update(int oldID, Activity newItem)
        {
            var oldItem = demoDBContext.Activities.FirstOrDefault(item => item.ActID == oldID);
            oldItem.ActID = newItem.ActID;
            oldItem.ActDate = newItem.ActDate;
            oldItem.EmpID = newItem.EmpID;
            oldItem.TaskID = newItem.TaskID;
            oldItem.ActTime = newItem.ActTime;
            oldItem.ActDescription = newItem.ActDescription;
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Returns the repository as a string.
        /// </summary>
        /// <returns>StringBuilder.</returns>
        public StringBuilder GetTableContents()
        {
            List<Activity> activities = GetAll().ToList();
            StringBuilder builder = new StringBuilder();
            foreach (var x in activities)
            {
                builder.AppendLine("ActID: " + x.ActID + " | ActDate: " + x.ActDate + " | EmpName: " + x.EmpID
                    + " | TaskName: " + x.TaskID + " | ActTime " + x.ActTime
                    + " | ActDescription: " + x.ActDescription);
            }
            return builder;
        }
    }
}
