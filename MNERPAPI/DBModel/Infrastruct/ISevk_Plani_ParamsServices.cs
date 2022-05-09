
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ISevk_Plani_ParamsServices
    {

        public Task<List<Sevk_Plani_Params>> GetSevk_Plani_Params();
        
        public Task<Sevk_Plani_Params> GetSevk_Plani_ParamsById(int id);
        
        public Task<bool> CreateSevk_Plani_ParamsAsync(Sevk_Plani_Params model);
        
        public Task<bool> UpdateSevk_Plani_ParamsAsync(Sevk_Plani_Params model);
 
        public Task<bool> DeleteSevk_Plani_ParamsAsync(int ID);   
    }
}


