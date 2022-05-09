

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class HIZMET_BIRIMLERServices : IHIZMET_BIRIMLERServices
    {
        private readonly IHIZMET_BIRIMLERRepository _HIZMET_BIRIMLERRepository;

        public  HIZMET_BIRIMLERServices(IHIZMET_BIRIMLERRepository _HIZMET_BIRIMLERRepository)
        {
            this._HIZMET_BIRIMLERRepository = _HIZMET_BIRIMLERRepository;
        }

        public async Task<bool> CreateHIZMET_BIRIMLERAsync(HIZMET_BIRIMLER model)
        {
            return await _HIZMET_BIRIMLERRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteHIZMET_BIRIMLERAsync(int ID)
        {
            return await _HIZMET_BIRIMLERRepository.DeleteAsync(ID);
        }

        public async Task<List<HIZMET_BIRIMLER>> GetHIZMET_BIRIMLER()
        {
            return await _HIZMET_BIRIMLERRepository.GetAllAsync();
        }

        public async Task<HIZMET_BIRIMLER> GetHIZMET_BIRIMLERById(int ID)
        {
            return await _HIZMET_BIRIMLERRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateHIZMET_BIRIMLERAsync(HIZMET_BIRIMLER model)
        {
            return await _HIZMET_BIRIMLERRepository.UpdateAsync(model);
        }
    }


}



