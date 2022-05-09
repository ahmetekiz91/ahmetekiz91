
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMalz_Hareket_ParamsServices
    {

        public Task<List<Malz_Hareket_Params>> GetMalz_Hareket_Params();
        
        public Task<Malz_Hareket_Params> GetMalz_Hareket_ParamsById(int id);
        
        public Task<bool> CreateMalz_Hareket_ParamsAsync(Malz_Hareket_Params model);
        
        public Task<bool> UpdateMalz_Hareket_ParamsAsync(Malz_Hareket_Params model);
 
        public Task<bool> DeleteMalz_Hareket_ParamsAsync(int ID);   
    }
}


