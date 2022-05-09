
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ISip_KalemServices
    {

        public Task<List<Sip_Kalem>> GetSip_Kalem();
        
        public Task<Sip_Kalem> GetSip_KalemById(int id);
        
        public Task<bool> CreateSip_KalemAsync(Sip_Kalem model);
        
        public Task<bool> UpdateSip_KalemAsync(Sip_Kalem model);
 
        public Task<bool> DeleteSip_KalemAsync(int ID);   
    }
}


