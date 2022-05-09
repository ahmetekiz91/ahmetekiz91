
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMALZ_ROTA_URETILENServices
    {

        public Task<List<MALZ_ROTA_URETILEN>> GetMALZ_ROTA_URETILEN();
        
        public Task<MALZ_ROTA_URETILEN> GetMALZ_ROTA_URETILENById(int id);
        
        public Task<bool> CreateMALZ_ROTA_URETILENAsync(MALZ_ROTA_URETILEN model);
        
        public Task<bool> UpdateMALZ_ROTA_URETILENAsync(MALZ_ROTA_URETILEN model);
 
        public Task<bool> DeleteMALZ_ROTA_URETILENAsync(int ID);   
    }
}


