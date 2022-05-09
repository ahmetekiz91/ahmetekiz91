
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITeklif_Revizyon_KalemServices
    {

        public Task<List<Teklif_Revizyon_Kalem>> GetTeklif_Revizyon_Kalem();
        
        public Task<Teklif_Revizyon_Kalem> GetTeklif_Revizyon_KalemById(int id);
        
        public Task<bool> CreateTeklif_Revizyon_KalemAsync(Teklif_Revizyon_Kalem model);
        
        public Task<bool> UpdateTeklif_Revizyon_KalemAsync(Teklif_Revizyon_Kalem model);
 
        public Task<bool> DeleteTeklif_Revizyon_KalemAsync(int ID);   
    }
}


