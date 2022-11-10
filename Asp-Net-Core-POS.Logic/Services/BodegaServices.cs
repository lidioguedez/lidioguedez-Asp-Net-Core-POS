using Asp_Net_Core_POS.Core.Model;
using Asp_Net_Core_POS.Logic.Interface;
using Asp_Net_Core_POS.Logic.Repository.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp_Net_Core_POS.Logic.Services
{
    public class BodegaServices : IBodegaServices
    {
        private readonly IUnitOfWork _unitWork;

        public BodegaServices(IUnitOfWork unitWork)
        {
            _unitWork = unitWork;
        }


        public async Task Delete(Bodega entity)
        {
            await _unitWork.BodegaRepository.delete(entity);
            await SaveChanges();
        }

        public async Task<IReadOnlyList<Bodega>> GetAll()
        {
            return await _unitWork.BodegaRepository.getAllAsinc();
        }

        public async Task<Bodega> GetById(int id)
        {
            return await _unitWork.BodegaRepository.getByIdAsinc(id);
        }

        public async Task Insert(Bodega entity)
        {
           await _unitWork.BodegaRepository.insertAsinc(entity);
            await SaveChanges();
        }

        public async Task SaveChanges()
        {
            await _unitWork.saveChangesAsinc();
        }

        public async Task Update(Bodega entity)
        {
            await _unitWork.BodegaRepository.updateAsinc(entity);
            await SaveChanges();
        }
    }
}
