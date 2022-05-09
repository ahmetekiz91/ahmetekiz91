

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{

    public class MALZ_BIRIMServices : IMALZ_BIRIMServices
    {
        private readonly IMALZ_BIRIMRepository _MALZ_BIRIMRepository;

        public  MALZ_BIRIMServices(IMALZ_BIRIMRepository _MALZ_BIRIMRepository)
        {
            this._MALZ_BIRIMRepository = _MALZ_BIRIMRepository;
        }

        public async Task<bool> CreateMALZ_BIRIMAsync(MALZ_BIRIM model)
        {
            return await _MALZ_BIRIMRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMALZ_BIRIMAsync(int ID)
        {
            return await _MALZ_BIRIMRepository.DeleteAsync(ID);
        }

        public async Task<List<MALZ_BIRIM>> GetMALZ_BIRIM()
        {
            return await _MALZ_BIRIMRepository.GetAllAsync();
        }

        public async Task<MALZ_BIRIM> GetMALZ_BIRIMById(int ID)
        {
            return await _MALZ_BIRIMRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMALZ_BIRIMAsync(MALZ_BIRIM model)
        {
            return await _MALZ_BIRIMRepository.UpdateAsync(model);
        }
    }


}



