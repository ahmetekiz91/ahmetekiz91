

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class BORDRO_BORCLU_KISIServices : IBORDRO_BORCLU_KISIServices
    {
        private readonly IBORDRO_BORCLU_KISIRepository _BORDRO_BORCLU_KISIRepository;

        public  BORDRO_BORCLU_KISIServices(IBORDRO_BORCLU_KISIRepository _BORDRO_BORCLU_KISIRepository)
        {
            this._BORDRO_BORCLU_KISIRepository = _BORDRO_BORCLU_KISIRepository;
        }

        public async Task<bool> CreateBORDRO_BORCLU_KISIAsync(BORDRO_BORCLU_KISI model)
        {
            return await _BORDRO_BORCLU_KISIRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteBORDRO_BORCLU_KISIAsync(int ID)
        {
            return await _BORDRO_BORCLU_KISIRepository.DeleteAsync(ID);
        }

        public async Task<List<BORDRO_BORCLU_KISI>> GetBORDRO_BORCLU_KISI()
        {
            return await _BORDRO_BORCLU_KISIRepository.GetAllAsync();
        }

        public async Task<BORDRO_BORCLU_KISI> GetBORDRO_BORCLU_KISIById(int ID)
        {
            return await _BORDRO_BORCLU_KISIRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateBORDRO_BORCLU_KISIAsync(BORDRO_BORCLU_KISI model)
        {
            return await _BORDRO_BORCLU_KISIRepository.UpdateAsync(model);
        }
    }


}



