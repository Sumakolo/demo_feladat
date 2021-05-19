using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Data;

namespace Demo.Repository
{
    class ActivityRepository : IRepository<Activity>
    {
        DemoDBContext demoDBContext;

        /// <summary>
        /// Add one activity to the database.
        /// </summary>
        /// <param name="item"></param>
        public void AddOne(Activity item)
        {
            demoDBContext.activities.Add(item);
        }

        /// <summary>
        /// Delete one activity from the database.
        /// </summary>
        /// <param name="item"></param>
        public void DeleteOne(Activity item)
        {
            demoDBContext.activities.Remove(item);
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
    }
}
