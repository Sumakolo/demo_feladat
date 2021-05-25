using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Repository;
using Demo.Data;

namespace Demo.Logic
{
    public class ActivityLogic : ILogic<Activity>
    {     
        ActivityRepository activityRepository;
        
        /// <summary>
        /// Constructor for the ActivityLogic class.
        /// </summary>
        /// <param name="activityRepository"></param>
        public ActivityLogic(ActivityRepository activityRepository)
        {          
            this.activityRepository = activityRepository;
        }

        /// <summary>
        /// Add a new activity to the database.
        /// </summary>
        /// <param name="item"></param>
        public void Create(Activity item)
        {
            activityRepository.AddOne(item);
            
        }

        /// <summary>
        /// Delete an activity from the database by it's ID.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            activityRepository.DeleteOneByID(id);
        }

        /// <summary>
        /// Returns all activities from the database.
        /// </summary>
        /// <returns>IList<Activity></returns>
        public IList<Activity> GetAll()
        {
            return activityRepository.GetAll();
        }

        /// <summary>
        /// Update an activity.
        /// </summary>
        /// <param name="oldid"></param>
        /// <param name="newitem"></param>
        public void Update(int oldid, Activity newitem)
        {
            activityRepository.Update(oldid, newitem);
        }

        /// <summary>
        /// Returns the the activities data from the database as a string.
        /// </summary>
        /// <returns>StringBuilder</returns>
        public StringBuilder GetActivityData()
        {
            return activityRepository.GetTableContents();
        }
    }
}
