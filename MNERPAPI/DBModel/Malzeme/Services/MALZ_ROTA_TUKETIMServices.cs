

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MALZ_ROTA_TUKETIMServices : IMALZ_ROTA_TUKETIMServices
    {
        private readonly IMALZ_ROTA_TUKETIMRepository _MALZ_ROTA_TUKETIMRepository;

        public  MALZ_ROTA_TUKETIMServices(IMALZ_ROTA_TUKETIMRepository _MALZ_ROTA_TUKETIMRepository)
        {
            this._MALZ_ROTA_TUKETIMRepository = _MALZ_ROTA_TUKETIMRepository;
        }

        public async Task<bool> CreateMALZ_ROTA_TUKETIMAsync(MALZ_ROTA_TUKETIM model)
        {
            return await _MALZ_ROTA_TUKETIMRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMALZ_ROTA_TUKETIMAsync(int ID)
        {
            return await _MALZ_ROTA_TUKETIMRepository.DeleteAsync(ID);
        }

        public async Task<List<MALZ_ROTA_TUKETIM>> GetMALZ_ROTA_TUKETIM()
        {
            return await _MALZ_ROTA_TUKETIMRepository.GetAllAsync();
        }

        public async Task<MALZ_ROTA_TUKETIM> GetMALZ_ROTA_TUKETIMById(int ID)
        {
            return await _MALZ_ROTA_TUKETIMRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMALZ_ROTA_TUKETIMAsync(MALZ_ROTA_TUKETIM model)
        {
            return await _MALZ_ROTA_TUKETIMRepository.UpdateAsync(model);
        }
    }


}



