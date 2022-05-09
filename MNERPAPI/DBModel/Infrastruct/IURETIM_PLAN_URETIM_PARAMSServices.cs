
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IURETIM_PLAN_URETIM_PARAMSServices
    {

        public Task<List<URETIM_PLAN_URETIM_PARAMS>> GetURETIM_PLAN_URETIM_PARAMS();
        
        public Task<URETIM_PLAN_URETIM_PARAMS> GetURETIM_PLAN_URETIM_PARAMSById(int id);
        
        public Task<bool> CreateURETIM_PLAN_URETIM_PARAMSAsync(URETIM_PLAN_URETIM_PARAMS model);
        
        public Task<bool> UpdateURETIM_PLAN_URETIM_PARAMSAsync(URETIM_PLAN_URETIM_PARAMS model);
 
        public Task<bool> DeleteURETIM_PLAN_URETIM_PARAMSAsync(int ID);   
    }
}


