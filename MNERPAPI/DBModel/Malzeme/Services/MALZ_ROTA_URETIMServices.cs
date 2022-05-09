

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MALZ_ROTA_URETIMServices : IMALZ_ROTA_URETIMServices
    {
        private readonly IMALZ_ROTA_URETIMRepository _MALZ_ROTA_URETIMRepository;

        public  MALZ_ROTA_URETIMServices(IMALZ_ROTA_URETIMRepository _MALZ_ROTA_URETIMRepository)
        {
            this._MALZ_ROTA_URETIMRepository = _MALZ_ROTA_URETIMRepository;
        }

        public async Task<bool> CreateMALZ_ROTA_URETIMAsync(MALZ_ROTA_URETIM model)
        {
            return await _MALZ_ROTA_URETIMRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMALZ_ROTA_URETIMAsync(int ID)
        {
            return await _MALZ_ROTA_URETIMRepository.DeleteAsync(ID);
        }

        public async Task<List<MALZ_ROTA_URETIM>> GetMALZ_ROTA_URETIM()
        {
            return await _MALZ_ROTA_URETIMRepository.GetAllAsync();
        }

        public async Task<MALZ_ROTA_URETIM> GetMALZ_ROTA_URETIMById(int ID)
        {
            return await _MALZ_ROTA_URETIMRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMALZ_ROTA_URETIMAsync(MALZ_ROTA_URETIM model)
        {
            return await _MALZ_ROTA_URETIMRepository.UpdateAsync(model);
        }
    }


}



