
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMalz_HareketServices
    {

        public Task<List<Malz_Hareket>> GetMalz_Hareket();
        
        public Task<Malz_Hareket> GetMalz_HareketById(int id);
        
        public Task<bool> CreateMalz_HareketAsync(Malz_Hareket model);
        
        public Task<bool> UpdateMalz_HareketAsync(Malz_Hareket model);
 
        public Task<bool> DeleteMalz_HareketAsync(int ID);   
    }
}


