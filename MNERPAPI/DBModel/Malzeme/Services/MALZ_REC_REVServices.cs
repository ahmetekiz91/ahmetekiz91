

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MALZ_REC_REVServices : IMALZ_REC_REVServices
    {
        private readonly IMALZ_REC_REVRepository _MALZ_REC_REVRepository;

        public  MALZ_REC_REVServices(IMALZ_REC_REVRepository _MALZ_REC_REVRepository)
        {
            this._MALZ_REC_REVRepository = _MALZ_REC_REVRepository;
        }

        public async Task<bool> CreateMALZ_REC_REVAsync(MALZ_REC_REV model)
        {
            return await _MALZ_REC_REVRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMALZ_REC_REVAsync(int ID)
        {
            return await _MALZ_REC_REVRepository.DeleteAsync(ID);
        }

        public async Task<List<MALZ_REC_REV>> GetMALZ_REC_REV()
        {
            return await _MALZ_REC_REVRepository.GetAllAsync();
        }

        public async Task<MALZ_REC_REV> GetMALZ_REC_REVById(int ID)
        {
            return await _MALZ_REC_REVRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMALZ_REC_REVAsync(MALZ_REC_REV model)
        {
            return await _MALZ_REC_REVRepository.UpdateAsync(model);
        }
    }


}



