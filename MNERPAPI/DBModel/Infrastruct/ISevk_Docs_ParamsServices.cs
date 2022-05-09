
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ISevk_Docs_ParamsServices
    {

        public Task<List<Sevk_Docs_Params>> GetSevk_Docs_Params();
        
        public Task<Sevk_Docs_Params> GetSevk_Docs_ParamsById(int id);
        
        public Task<bool> CreateSevk_Docs_ParamsAsync(Sevk_Docs_Params model);
        
        public Task<bool> UpdateSevk_Docs_ParamsAsync(Sevk_Docs_Params model);
 
        public Task<bool> DeleteSevk_Docs_ParamsAsync(int ID);   
    }
}


