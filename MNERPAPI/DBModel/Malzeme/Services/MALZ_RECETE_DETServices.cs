

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MALZ_RECETE_DETServices : IMALZ_RECETE_DETServices
    {
        private readonly IMALZ_RECETE_DETRepository _MALZ_RECETE_DETRepository;

        public  MALZ_RECETE_DETServices(IMALZ_RECETE_DETRepository _MALZ_RECETE_DETRepository)
        {
            this._MALZ_RECETE_DETRepository = _MALZ_RECETE_DETRepository;
        }

        public async Task<bool> CreateMALZ_RECETE_DETAsync(MALZ_RECETE_DET model)
        {
            return await _MALZ_RECETE_DETRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMALZ_RECETE_DETAsync(int ID)
        {
            return await _MALZ_RECETE_DETRepository.DeleteAsync(ID);
        }

        public async Task<List<MALZ_RECETE_DET>> GetMALZ_RECETE_DET()
        {
            return await _MALZ_RECETE_DETRepository.GetAllAsync();
        }

        public async Task<MALZ_RECETE_DET> GetMALZ_RECETE_DETById(int ID)
        {
            return await _MALZ_RECETE_DETRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMALZ_RECETE_DETAsync(MALZ_RECETE_DET model)
        {
            return await _MALZ_RECETE_DETRepository.UpdateAsync(model);
        }
    }


}



