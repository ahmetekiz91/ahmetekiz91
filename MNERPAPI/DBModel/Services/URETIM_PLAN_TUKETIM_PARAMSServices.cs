

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class URETIM_PLAN_TUKETIM_PARAMSServices : IURETIM_PLAN_TUKETIM_PARAMSServices
    {
        private readonly IURETIM_PLAN_TUKETIM_PARAMSRepository _URETIM_PLAN_TUKETIM_PARAMSRepository;

        public  URETIM_PLAN_TUKETIM_PARAMSServices(IURETIM_PLAN_TUKETIM_PARAMSRepository _URETIM_PLAN_TUKETIM_PARAMSRepository)
        {
            this._URETIM_PLAN_TUKETIM_PARAMSRepository = _URETIM_PLAN_TUKETIM_PARAMSRepository;
        }

        public async Task<bool> CreateURETIM_PLAN_TUKETIM_PARAMSAsync(URETIM_PLAN_TUKETIM_PARAMS model)
        {
            return await _URETIM_PLAN_TUKETIM_PARAMSRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteURETIM_PLAN_TUKETIM_PARAMSAsync(int ID)
        {
            return await _URETIM_PLAN_TUKETIM_PARAMSRepository.DeleteAsync(ID);
        }

        public async Task<List<URETIM_PLAN_TUKETIM_PARAMS>> GetURETIM_PLAN_TUKETIM_PARAMS()
        {
            return await _URETIM_PLAN_TUKETIM_PARAMSRepository.GetAllAsync();
        }

        public async Task<URETIM_PLAN_TUKETIM_PARAMS> GetURETIM_PLAN_TUKETIM_PARAMSById(int ID)
        {
            return await _URETIM_PLAN_TUKETIM_PARAMSRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateURETIM_PLAN_TUKETIM_PARAMSAsync(URETIM_PLAN_TUKETIM_PARAMS model)
        {
            return await _URETIM_PLAN_TUKETIM_PARAMSRepository.UpdateAsync(model);
        }
    }


}



