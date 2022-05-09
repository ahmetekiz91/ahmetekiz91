
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITalep_Detay_ParamsServices
    {

        public Task<List<Talep_Detay_Params>> GetTalep_Detay_Params();
        
        public Task<Talep_Detay_Params> GetTalep_Detay_ParamsById(int id);
        
        public Task<bool> CreateTalep_Detay_ParamsAsync(Talep_Detay_Params model);
        
        public Task<bool> UpdateTalep_Detay_ParamsAsync(Talep_Detay_Params model);
 
        public Task<bool> DeleteTalep_Detay_ParamsAsync(int ID);   
    }
}


