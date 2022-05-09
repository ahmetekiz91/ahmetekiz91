
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMALZ_BRMDONServices
    {

        public Task<List<MALZ_BRMDON>> GetMALZ_BRMDON();
        
        public Task<MALZ_BRMDON> GetMALZ_BRMDONById(int id);
        
        public Task<bool> CreateMALZ_BRMDONAsync(MALZ_BRMDON model);
        
        public Task<bool> UpdateMALZ_BRMDONAsync(MALZ_BRMDON model);
 
        public Task<bool> DeleteMALZ_BRMDONAsync(int ID);   
    }
}


