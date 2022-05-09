
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IKasa_HareketServices
    {

        public Task<List<Kasa_Hareket>> GetKasa_Hareket();
        
        public Task<Kasa_Hareket> GetKasa_HareketById(int id);
        
        public Task<bool> CreateKasa_HareketAsync(Kasa_Hareket model);
        
        public Task<bool> UpdateKasa_HareketAsync(Kasa_Hareket model);
 
        public Task<bool> DeleteKasa_HareketAsync(int ID);   
    }
}


