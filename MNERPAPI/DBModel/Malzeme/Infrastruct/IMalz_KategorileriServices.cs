
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMalz_KategorileriServices
    {

        public Task<List<Malz_Kategorileri>> GetMalz_Kategorileri();
        
        public Task<Malz_Kategorileri> GetMalz_KategorileriById(int id);
        
        public Task<bool> CreateMalz_KategorileriAsync(Malz_Kategorileri model);
        
        public Task<bool> UpdateMalz_KategorileriAsync(Malz_Kategorileri model);
 
        public Task<bool> DeleteMalz_KategorileriAsync(int ID);   
    }
}


