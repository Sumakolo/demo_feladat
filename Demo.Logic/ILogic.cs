using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Logic
{
    public interface ILogic<T>
    {
        void Create(T item);
        void Update(string oldid, T newitem);
        void Delete(T item);
        void Delete(string id);
        IList<T> GetAll();
    }
}
