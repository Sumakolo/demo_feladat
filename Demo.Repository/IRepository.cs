using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository
{
    public interface IRepository<T>
    {
        /// <summary>
        /// Get all T items.
        /// </summary>
        /// <returns></returns>
        IList<T> GetAll();

        /// <summary>
        /// Get one T item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>T</returns>
        void AddOne(T item);

        /// <summary>
        /// Delete one T item.
        /// </summary>
        /// <param name="item"></param>
        void DeleteOne(T item);
    }
}
