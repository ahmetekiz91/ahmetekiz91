
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ISip_Kalem_ParamsServices
    {

        public Task<List<Sip_Kalem_Params>> GetSip_Kalem_Params();
        
        public Task<Sip_Kalem_Params> GetSip_Kalem_ParamsById(int id);
        
        public Task<bool> CreateSip_Kalem_ParamsAsync(Sip_Kalem_Params model);
        
        public Task<bool> UpdateSip_Kalem_ParamsAsync(Sip_Kalem_Params model);
 
        public Task<bool> DeleteSip_Kalem_ParamsAsync(int ID);   
    }
}


