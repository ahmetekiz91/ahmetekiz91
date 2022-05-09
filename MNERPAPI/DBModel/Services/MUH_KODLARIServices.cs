

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MUH_KODLARIServices : IMUH_KODLARIServices
    {
        private readonly IMUH_KODLARIRepository _MUH_KODLARIRepository;

        public  MUH_KODLARIServices(IMUH_KODLARIRepository _MUH_KODLARIRepository)
        {
            this._MUH_KODLARIRepository = _MUH_KODLARIRepository;
        }

        public async Task<bool> CreateMUH_KODLARIAsync(MUH_KODLARI model)
        {
            return await _MUH_KODLARIRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMUH_KODLARIAsync(int ID)
        {
            return await _MUH_KODLARIRepository.DeleteAsync(ID);
        }

        public async Task<List<MUH_KODLARI>> GetMUH_KODLARI()
        {
            return await _MUH_KODLARIRepository.GetAllAsync();
        }

        public async Task<MUH_KODLARI> GetMUH_KODLARIById(int ID)
        {
            return await _MUH_KODLARIRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMUH_KODLARIAsync(MUH_KODLARI model)
        {
            return await _MUH_KODLARIRepository.UpdateAsync(model);
        }
    }


}



