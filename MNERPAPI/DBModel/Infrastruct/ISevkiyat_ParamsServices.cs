
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ISevkiyat_ParamsServices
    {

        public Task<List<Sevkiyat_Params>> GetSevkiyat_Params();
        
        public Task<Sevkiyat_Params> GetSevkiyat_ParamsById(int id);
        
        public Task<bool> CreateSevkiyat_ParamsAsync(Sevkiyat_Params model);
        
        public Task<bool> UpdateSevkiyat_ParamsAsync(Sevkiyat_Params model);
 
        public Task<bool> DeleteSevkiyat_ParamsAsync(int ID);   
    }
}


