
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMALZ_ROTAServices
    {

        public Task<List<MALZ_ROTA>> GetMALZ_ROTA();
        
        public Task<MALZ_ROTA> GetMALZ_ROTAById(int id);
        
        public Task<bool> CreateMALZ_ROTAAsync(MALZ_ROTA model);
        
        public Task<bool> UpdateMALZ_ROTAAsync(MALZ_ROTA model);
 
        public Task<bool> DeleteMALZ_ROTAAsync(int ID);   
    }
}


