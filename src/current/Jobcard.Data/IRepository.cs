using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jobcard.Data
{
    public interface IRepository<T>
    {
        T Get(int id);
        IAsyncEnumerable<T> GetAll();
        T Create(T entity);
        Task Delete(int id);
    }
}
