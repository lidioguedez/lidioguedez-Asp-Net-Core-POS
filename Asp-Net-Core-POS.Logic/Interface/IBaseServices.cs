using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp_Net_Core_POS.Logic.Interface
{
    public interface IBaseServices<T> where T : class
    {
        Task Delete(T entity);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T entity);
        Task SaveChanges();
        Task Update(T entity);
    }
}
