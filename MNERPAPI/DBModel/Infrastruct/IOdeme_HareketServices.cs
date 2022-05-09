
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IOdeme_HareketServices
    {

        public Task<List<Odeme_Hareket>> GetOdeme_Hareket();
        
        public Task<Odeme_Hareket> GetOdeme_HareketById(int id);
        
        public Task<bool> CreateOdeme_HareketAsync(Odeme_Hareket model);
        
        public Task<bool> UpdateOdeme_HareketAsync(Odeme_Hareket model);
 
        public Task<bool> DeleteOdeme_HareketAsync(int ID);   
    }
}


