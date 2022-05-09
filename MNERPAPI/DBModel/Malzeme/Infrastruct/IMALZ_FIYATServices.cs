
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMALZ_FIYATServices
    {

        public Task<List<MALZ_FIYAT>> GetMALZ_FIYAT();
        
        public Task<MALZ_FIYAT> GetMALZ_FIYATById(int id);
        
        public Task<bool> CreateMALZ_FIYATAsync(MALZ_FIYAT model);
        
        public Task<bool> UpdateMALZ_FIYATAsync(MALZ_FIYAT model);
 
        public Task<bool> DeleteMALZ_FIYATAsync(int ID);   
    }
}


