using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        void Create(T item);
        void Delete(int id);
        IEnumerable<T> Find(Func<T, bool> predicate, int pageNumber = 0, int pageSize = 10);
        T Get(int id);
        IEnumerable<T> GetAll();
        void Update(T item);
    }
}
