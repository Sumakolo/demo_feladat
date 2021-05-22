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
        void Update(int oldid, T newitem);
        void Delete(int id);
        IList<T> GetAll();
    }
}
