

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MALZ_BRMDONServices : IMALZ_BRMDONServices
    {
        private readonly IMALZ_BRMDONRepository _MALZ_BRMDONRepository;

        public  MALZ_BRMDONServices(IMALZ_BRMDONRepository _MALZ_BRMDONRepository)
        {
            this._MALZ_BRMDONRepository = _MALZ_BRMDONRepository;
        }

        public async Task<bool> CreateMALZ_BRMDONAsync(MALZ_BRMDON model)
        {
            return await _MALZ_BRMDONRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMALZ_BRMDONAsync(int ID)
        {
            return await _MALZ_BRMDONRepository.DeleteAsync(ID);
        }

        public async Task<List<MALZ_BRMDON>> GetMALZ_BRMDON()
        {
            return await _MALZ_BRMDONRepository.GetAllAsync();
        }

        public async Task<MALZ_BRMDON> GetMALZ_BRMDONById(int ID)
        {
            return await _MALZ_BRMDONRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMALZ_BRMDONAsync(MALZ_BRMDON model)
        {
            return await _MALZ_BRMDONRepository.UpdateAsync(model);
        }
    }


}



