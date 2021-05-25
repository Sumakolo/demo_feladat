using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository
{
    public interface IRepository<T>
    {       
        IList<T> GetAll();     
        void AddOne(T item);      
        void DeleteOneByID(int id);  
        void Update(int oldID, T newItem);
        StringBuilder GetTableContents();
    }
}
