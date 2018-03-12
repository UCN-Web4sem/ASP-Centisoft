using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centisoft.Core.Contracts
{
    public interface IGenericInterface<T> where T: class
    {
        void Save(T t);
        T Get(int id);
        List<T> GetAll();
        void Delete(T t);
    }
}
