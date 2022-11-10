using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp_Net_Core_POS.Logic.Repository.Interfases
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> getAllAsinc();
        Task<T> getByIdAsinc(int id);
        Task insertAsinc(T entity);
        Task delete(T entity);
        Task updateAsinc(T entity);

    }
}
