
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMALZ_ROTA_ISTServices
    {

        public Task<List<MALZ_ROTA_IST>> GetMALZ_ROTA_IST();
        
        public Task<MALZ_ROTA_IST> GetMALZ_ROTA_ISTById(int id);
        
        public Task<bool> CreateMALZ_ROTA_ISTAsync(MALZ_ROTA_IST model);
        
        public Task<bool> UpdateMALZ_ROTA_ISTAsync(MALZ_ROTA_IST model);
 
        public Task<bool> DeleteMALZ_ROTA_ISTAsync(int ID);   
    }
}


