
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITeklif_RevizyonServices
    {

        public Task<List<Teklif_Revizyon>> GetTeklif_Revizyon();
        
        public Task<Teklif_Revizyon> GetTeklif_RevizyonById(int id);
        
        public Task<bool> CreateTeklif_RevizyonAsync(Teklif_Revizyon model);
        
        public Task<bool> UpdateTeklif_RevizyonAsync(Teklif_Revizyon model);
 
        public Task<bool> DeleteTeklif_RevizyonAsync(int ID);   
    }
}


