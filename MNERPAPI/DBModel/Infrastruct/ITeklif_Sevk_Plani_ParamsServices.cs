
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITeklif_Sevk_Plani_ParamsServices
    {

        public Task<List<Teklif_Sevk_Plani_Params>> GetTeklif_Sevk_Plani_Params();
        
        public Task<Teklif_Sevk_Plani_Params> GetTeklif_Sevk_Plani_ParamsById(int id);
        
        public Task<bool> CreateTeklif_Sevk_Plani_ParamsAsync(Teklif_Sevk_Plani_Params model);
        
        public Task<bool> UpdateTeklif_Sevk_Plani_ParamsAsync(Teklif_Sevk_Plani_Params model);
 
        public Task<bool> DeleteTeklif_Sevk_Plani_ParamsAsync(int ID);   
    }
}


