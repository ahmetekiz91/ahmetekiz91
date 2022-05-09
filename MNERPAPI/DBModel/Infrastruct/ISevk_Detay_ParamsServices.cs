
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ISevk_Detay_ParamsServices
    {

        public Task<List<Sevk_Detay_Params>> GetSevk_Detay_Params();
        
        public Task<Sevk_Detay_Params> GetSevk_Detay_ParamsById(int id);
        
        public Task<bool> CreateSevk_Detay_ParamsAsync(Sevk_Detay_Params model);
        
        public Task<bool> UpdateSevk_Detay_ParamsAsync(Sevk_Detay_Params model);
 
        public Task<bool> DeleteSevk_Detay_ParamsAsync(int ID);   
    }
}


