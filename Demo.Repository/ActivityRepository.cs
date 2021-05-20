using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Data;

namespace Demo.Repository
{
    public class ActivityRepository : IRepository<Activity>
    {
        DemoDBContext demoDBContext = new DemoDBContext();

        /// <summary>
        /// Add one activity to the database.
        /// </summary>
        /// <param name="item"></param>
        public void AddOne(Activity item)
        {
            demoDBContext.activities.Add(item);
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Delete one activity from the database.
        /// </summary>
        /// <param name="item"></param>
        public void DeleteOne(Activity item)
        {
            demoDBContext.activities.Remove(item);
            demoDBContext.SaveChanges();
        }

        /// <summary>
        /// Delete one activity from the database by id.
        /// </summary>
        /// <param name="item"></param>
        public void DeleteOneByID(string id)
        {
            Activity activity = demoDBContext.activities.FirstOrDefault(item => item.ActID == id);
            DeleteOne(activity);
        }

        /// <summary>
        /// Returns all activities from the database.
        /// </summary>
        /// <returns></returns>
        public IList<Activity> GetAll()
        {
            return demoDBContext.activities.ToList();
        }

        /// <summary>
        /// Returns an Activity by its ID.
        /// </summary>
        /// <param name="ActID"></param>
        /// <returns></returns>
        public Activity GetOneById(string ActID)
        {
            return demoDBContext.activities.FirstOrDefault(item => item.ActID == ActID);
        }

        /// <summary>
        /// Updates an activity in the database.
        /// </summary>
        /// <param name="oldID"></param>
        /// <param name="newItem"></param>
        public void Update(string oldID, Activity newItem)
        {
            var oldItem = demoDBContext.activities.FirstOrDefault(item => item.ActID == oldID);
            oldItem.ActID = newItem.ActID;
            oldItem.ActDate = newItem.ActDate;
            oldItem.EmpName = newItem.EmpName;
            oldItem.TaskName = newItem.TaskName;
            oldItem.ActTimeHours = newItem.ActTimeHours;
            oldItem.ActTimeMinutes = newItem.ActTimeMinutes;
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
                builder.AppendLine("ActID: " + x.ActID + " | ActDate: " + x.ActDate + " | EmpName: " + x.EmpName
                    + " | TaskName: " + x.TaskName + " | ActTime " + x.ActTimeHours + ":" + x.ActTimeMinutes
                    + " | ActDescription: " + x.ActDescription);
            }
            return builder;
        }    
    }
}
