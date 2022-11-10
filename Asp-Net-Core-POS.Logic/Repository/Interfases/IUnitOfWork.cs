using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp_Net_Core_POS.Logic.Repository.Interfases
{
    public interface IUnitOfWork
    {
        IBodegaRepository BodegaRepository { get; }
        Task saveChangesAsinc();
    }
}
