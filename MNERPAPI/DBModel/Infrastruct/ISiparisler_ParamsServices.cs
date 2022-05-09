
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ISiparisler_ParamsServices
    {

        public Task<List<Siparisler_Params>> GetSiparisler_Params();
        
        public Task<Siparisler_Params> GetSiparisler_ParamsById(int id);
        
        public Task<bool> CreateSiparisler_ParamsAsync(Siparisler_Params model);
        
        public Task<bool> UpdateSiparisler_ParamsAsync(Siparisler_Params model);
 
        public Task<bool> DeleteSiparisler_ParamsAsync(int ID);   
    }
}


