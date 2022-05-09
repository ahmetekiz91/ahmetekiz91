
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITeklif_Revizyon_Kalem_ParamsServices
    {

        public Task<List<Teklif_Revizyon_Kalem_Params>> GetTeklif_Revizyon_Kalem_Params();
        
        public Task<Teklif_Revizyon_Kalem_Params> GetTeklif_Revizyon_Kalem_ParamsById(int id);
        
        public Task<bool> CreateTeklif_Revizyon_Kalem_ParamsAsync(Teklif_Revizyon_Kalem_Params model);
        
        public Task<bool> UpdateTeklif_Revizyon_Kalem_ParamsAsync(Teklif_Revizyon_Kalem_Params model);
 
        public Task<bool> DeleteTeklif_Revizyon_Kalem_ParamsAsync(int ID);   
    }
}


