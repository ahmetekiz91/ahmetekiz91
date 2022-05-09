
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IURETIM_PLAN_TUKETIM_PARAMSServices
    {

        public Task<List<URETIM_PLAN_TUKETIM_PARAMS>> GetURETIM_PLAN_TUKETIM_PARAMS();
        
        public Task<URETIM_PLAN_TUKETIM_PARAMS> GetURETIM_PLAN_TUKETIM_PARAMSById(int id);
        
        public Task<bool> CreateURETIM_PLAN_TUKETIM_PARAMSAsync(URETIM_PLAN_TUKETIM_PARAMS model);
        
        public Task<bool> UpdateURETIM_PLAN_TUKETIM_PARAMSAsync(URETIM_PLAN_TUKETIM_PARAMS model);
 
        public Task<bool> DeleteURETIM_PLAN_TUKETIM_PARAMSAsync(int ID);   
    }
}


