
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMALZ_RECETE_DETServices
    {

        public Task<List<MALZ_RECETE_DET>> GetMALZ_RECETE_DET();
        
        public Task<MALZ_RECETE_DET> GetMALZ_RECETE_DETById(int id);
        
        public Task<bool> CreateMALZ_RECETE_DETAsync(MALZ_RECETE_DET model);
        
        public Task<bool> UpdateMALZ_RECETE_DETAsync(MALZ_RECETE_DET model);
 
        public Task<bool> DeleteMALZ_RECETE_DETAsync(int ID);   
    }
}


