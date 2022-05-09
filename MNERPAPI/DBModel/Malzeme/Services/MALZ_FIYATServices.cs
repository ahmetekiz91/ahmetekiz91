

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MALZ_FIYATServices : IMALZ_FIYATServices
    {
        private readonly IMALZ_FIYATRepository _MALZ_FIYATRepository;

        public  MALZ_FIYATServices(IMALZ_FIYATRepository _MALZ_FIYATRepository)
        {
            this._MALZ_FIYATRepository = _MALZ_FIYATRepository;
        }

        public async Task<bool> CreateMALZ_FIYATAsync(MALZ_FIYAT model)
        {
            return await _MALZ_FIYATRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMALZ_FIYATAsync(int ID)
        {
            return await _MALZ_FIYATRepository.DeleteAsync(ID);
        }

        public async Task<List<MALZ_FIYAT>> GetMALZ_FIYAT()
        {
            return await _MALZ_FIYATRepository.GetAllAsync();
        }

        public async Task<MALZ_FIYAT> GetMALZ_FIYATById(int ID)
        {
            return await _MALZ_FIYATRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMALZ_FIYATAsync(MALZ_FIYAT model)
        {
            return await _MALZ_FIYATRepository.UpdateAsync(model);
        }
    }


}



