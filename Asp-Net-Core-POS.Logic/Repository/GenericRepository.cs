using Asp_Net_Core_POS.Core.Model;
using Asp_Net_Core_POS.Logic.Data;
using Asp_Net_Core_POS.Logic.Repository.Interfases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp_Net_Core_POS.Logic.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : EntityBase
    {
        protected DbSet<T> _DbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _DbSet = context.Set<T>();
        }

        public async Task delete(T entity)
        {
            _DbSet.Remove(entity);
        }

        public async Task<IReadOnlyList<T>> getAllAsinc()
        {
            return await _DbSet.ToListAsync();
        }

        public async Task<T> getByIdAsinc(int id)
        {
            return await _DbSet.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task insertAsinc(T entity)
        {
            await _DbSet.AddAsync(entity);
        }


        public async Task updateAsinc(T entity)
        {
            _DbSet.Update(entity);
        }
    }
}
