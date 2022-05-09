

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class URETIM_PLAN_URETIM_PARAMSServices : IURETIM_PLAN_URETIM_PARAMSServices
    {
        private readonly IURETIM_PLAN_URETIM_PARAMSRepository _URETIM_PLAN_URETIM_PARAMSRepository;

        public  URETIM_PLAN_URETIM_PARAMSServices(IURETIM_PLAN_URETIM_PARAMSRepository _URETIM_PLAN_URETIM_PARAMSRepository)
        {
            this._URETIM_PLAN_URETIM_PARAMSRepository = _URETIM_PLAN_URETIM_PARAMSRepository;
        }

        public async Task<bool> CreateURETIM_PLAN_URETIM_PARAMSAsync(URETIM_PLAN_URETIM_PARAMS model)
        {
            return await _URETIM_PLAN_URETIM_PARAMSRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteURETIM_PLAN_URETIM_PARAMSAsync(int ID)
        {
            return await _URETIM_PLAN_URETIM_PARAMSRepository.DeleteAsync(ID);
        }

        public async Task<List<URETIM_PLAN_URETIM_PARAMS>> GetURETIM_PLAN_URETIM_PARAMS()
        {
            return await _URETIM_PLAN_URETIM_PARAMSRepository.GetAllAsync();
        }

        public async Task<URETIM_PLAN_URETIM_PARAMS> GetURETIM_PLAN_URETIM_PARAMSById(int ID)
        {
            return await _URETIM_PLAN_URETIM_PARAMSRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateURETIM_PLAN_URETIM_PARAMSAsync(URETIM_PLAN_URETIM_PARAMS model)
        {
            return await _URETIM_PLAN_URETIM_PARAMSRepository.UpdateAsync(model);
        }
    }


}



