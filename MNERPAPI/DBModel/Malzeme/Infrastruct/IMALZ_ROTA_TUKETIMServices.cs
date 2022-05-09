
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMALZ_ROTA_TUKETIMServices
    {

        public Task<List<MALZ_ROTA_TUKETIM>> GetMALZ_ROTA_TUKETIM();
        
        public Task<MALZ_ROTA_TUKETIM> GetMALZ_ROTA_TUKETIMById(int id);
        
        public Task<bool> CreateMALZ_ROTA_TUKETIMAsync(MALZ_ROTA_TUKETIM model);
        
        public Task<bool> UpdateMALZ_ROTA_TUKETIMAsync(MALZ_ROTA_TUKETIM model);
 
        public Task<bool> DeleteMALZ_ROTA_TUKETIMAsync(int ID);   
    }
}


