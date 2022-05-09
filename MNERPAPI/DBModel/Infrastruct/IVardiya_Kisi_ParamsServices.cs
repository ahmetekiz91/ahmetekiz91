
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IVardiya_Kisi_ParamsServices
    {

        public Task<List<Vardiya_Kisi_Params>> GetVardiya_Kisi_Params();
        
        public Task<Vardiya_Kisi_Params> GetVardiya_Kisi_ParamsById(int id);
        
        public Task<bool> CreateVardiya_Kisi_ParamsAsync(Vardiya_Kisi_Params model);
        
        public Task<bool> UpdateVardiya_Kisi_ParamsAsync(Vardiya_Kisi_Params model);
 
        public Task<bool> DeleteVardiya_Kisi_ParamsAsync(int ID);   
    }
}


