
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITeklif_Sevk_PlaniServices
    {

        public Task<List<Teklif_Sevk_Plani>> GetTeklif_Sevk_Plani();
        
        public Task<Teklif_Sevk_Plani> GetTeklif_Sevk_PlaniById(int id);
        
        public Task<bool> CreateTeklif_Sevk_PlaniAsync(Teklif_Sevk_Plani model);
        
        public Task<bool> UpdateTeklif_Sevk_PlaniAsync(Teklif_Sevk_Plani model);
 
        public Task<bool> DeleteTeklif_Sevk_PlaniAsync(int ID);   
    }
}


