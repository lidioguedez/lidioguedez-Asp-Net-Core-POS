using Asp_Net_Core_POS.Core.Model;
using Asp_Net_Core_POS.Logic.Data;
using Asp_Net_Core_POS.Logic.Repository.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp_Net_Core_POS.Logic.Repository
{
    internal class BodegaRepository : GenericRepository<Bodega>, IBodegaRepository
    {
        public BodegaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
