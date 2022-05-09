
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMALZ_ROTA_URETIMServices
    {

        public Task<List<MALZ_ROTA_URETIM>> GetMALZ_ROTA_URETIM();
        
        public Task<MALZ_ROTA_URETIM> GetMALZ_ROTA_URETIMById(int id);
        
        public Task<bool> CreateMALZ_ROTA_URETIMAsync(MALZ_ROTA_URETIM model);
        
        public Task<bool> UpdateMALZ_ROTA_URETIMAsync(MALZ_ROTA_URETIM model);
 
        public Task<bool> DeleteMALZ_ROTA_URETIMAsync(int ID);   
    }
}


