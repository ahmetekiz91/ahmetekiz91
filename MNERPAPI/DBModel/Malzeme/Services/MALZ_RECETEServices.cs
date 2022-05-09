

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MALZ_RECETEServices : IMALZ_RECETEServices
    {
        private readonly IMALZ_RECETERepository _MALZ_RECETERepository;

        public  MALZ_RECETEServices(IMALZ_RECETERepository _MALZ_RECETERepository)
        {
            this._MALZ_RECETERepository = _MALZ_RECETERepository;
        }

        public async Task<bool> CreateMALZ_RECETEAsync(MALZ_RECETE model)
        {
            return await _MALZ_RECETERepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMALZ_RECETEAsync(int ID)
        {
            return await _MALZ_RECETERepository.DeleteAsync(ID);
        }

        public async Task<List<MALZ_RECETE>> GetMALZ_RECETE()
        {
            return await _MALZ_RECETERepository.GetAllAsync();
        }

        public async Task<MALZ_RECETE> GetMALZ_RECETEById(int ID)
        {
            return await _MALZ_RECETERepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMALZ_RECETEAsync(MALZ_RECETE model)
        {
            return await _MALZ_RECETERepository.UpdateAsync(model);
        }
    }


}



