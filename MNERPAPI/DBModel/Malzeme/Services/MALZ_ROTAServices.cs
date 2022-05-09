

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MALZ_ROTAServices : IMALZ_ROTAServices
    {
        private readonly IMALZ_ROTARepository _MALZ_ROTARepository;

        public  MALZ_ROTAServices(IMALZ_ROTARepository _MALZ_ROTARepository)
        {
            this._MALZ_ROTARepository = _MALZ_ROTARepository;
        }

        public async Task<bool> CreateMALZ_ROTAAsync(MALZ_ROTA model)
        {
            return await _MALZ_ROTARepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMALZ_ROTAAsync(int ID)
        {
            return await _MALZ_ROTARepository.DeleteAsync(ID);
        }

        public async Task<List<MALZ_ROTA>> GetMALZ_ROTA()
        {
            return await _MALZ_ROTARepository.GetAllAsync();
        }

        public async Task<MALZ_ROTA> GetMALZ_ROTAById(int ID)
        {
            return await _MALZ_ROTARepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMALZ_ROTAAsync(MALZ_ROTA model)
        {
            return await _MALZ_ROTARepository.UpdateAsync(model);
        }
    }


}



