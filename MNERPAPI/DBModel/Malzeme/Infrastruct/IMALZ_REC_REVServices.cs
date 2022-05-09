
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMALZ_REC_REVServices
    {

        public Task<List<MALZ_REC_REV>> GetMALZ_REC_REV();
        
        public Task<MALZ_REC_REV> GetMALZ_REC_REVById(int id);
        
        public Task<bool> CreateMALZ_REC_REVAsync(MALZ_REC_REV model);
        
        public Task<bool> UpdateMALZ_REC_REVAsync(MALZ_REC_REV model);
 
        public Task<bool> DeleteMALZ_REC_REVAsync(int ID);   
    }
}


