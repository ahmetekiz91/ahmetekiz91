

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MALZ_ROTA_ISTServices : IMALZ_ROTA_ISTServices
    {
        private readonly IMALZ_ROTA_ISTRepository _MALZ_ROTA_ISTRepository;

        public  MALZ_ROTA_ISTServices(IMALZ_ROTA_ISTRepository _MALZ_ROTA_ISTRepository)
        {
            this._MALZ_ROTA_ISTRepository = _MALZ_ROTA_ISTRepository;
        }

        public async Task<bool> CreateMALZ_ROTA_ISTAsync(MALZ_ROTA_IST model)
        {
            return await _MALZ_ROTA_ISTRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMALZ_ROTA_ISTAsync(int ID)
        {
            return await _MALZ_ROTA_ISTRepository.DeleteAsync(ID);
        }

        public async Task<List<MALZ_ROTA_IST>> GetMALZ_ROTA_IST()
        {
            return await _MALZ_ROTA_ISTRepository.GetAllAsync();
        }

        public async Task<MALZ_ROTA_IST> GetMALZ_ROTA_ISTById(int ID)
        {
            return await _MALZ_ROTA_ISTRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMALZ_ROTA_ISTAsync(MALZ_ROTA_IST model)
        {
            return await _MALZ_ROTA_ISTRepository.UpdateAsync(model);
        }
    }


}



