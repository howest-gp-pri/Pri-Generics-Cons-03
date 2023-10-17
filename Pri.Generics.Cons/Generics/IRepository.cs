using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Generics.Cons.Generics
{
    public interface IRepository<T>
    {
        void Add (T toAdd);
        void Delete (T toDelete);
        IEnumerable<T> GetAll ();
        T Get(int index);
    }
}
