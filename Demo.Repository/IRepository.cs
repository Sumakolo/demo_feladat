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
        /// Add one T item.
        /// </summary>
        /// <returns></returns>
        void AddOne(T item);

        /// <summary>
        /// Delete one T item by it's id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void DeleteOneByID(int id);

        /// <summary>
        /// Update an item from the repository.
        /// </summary>
        /// <param name="oldID"></param>
        /// <param name="newItem"></param>
        void Update(int oldID, T newItem);

        /// <summary>
        /// Returns the repository contents as a string.
        /// </summary>
        /// <returns></returns>
        StringBuilder GetTableContents();
    }
}
