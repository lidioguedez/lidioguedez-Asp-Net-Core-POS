using Asp_Net_Core_POS.Logic.Data;
using Asp_Net_Core_POS.Logic.Repository.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp_Net_Core_POS.Logic.Repository
{

    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        private IBodegaRepository _bodegaRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IBodegaRepository BodegaRepository
        {
            get 
            {
                return _bodegaRepository = _bodegaRepository ?? new BodegaRepository(_context);
            }
        }

        public async Task saveChangesAsinc()
        {
           await _context.SaveChangesAsync();
        }
    }
}
