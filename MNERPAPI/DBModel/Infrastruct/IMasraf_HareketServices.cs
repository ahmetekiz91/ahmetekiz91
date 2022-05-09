
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMasraf_HareketServices
    {

        public Task<List<Masraf_Hareket>> GetMasraf_Hareket();
        
        public Task<Masraf_Hareket> GetMasraf_HareketById(int id);
        
        public Task<bool> CreateMasraf_HareketAsync(Masraf_Hareket model);
        
        public Task<bool> UpdateMasraf_HareketAsync(Masraf_Hareket model);
 
        public Task<bool> DeleteMasraf_HareketAsync(int ID);   
    }
}


