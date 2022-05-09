
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMALZ_RECETEServices
    {

        public Task<List<MALZ_RECETE>> GetMALZ_RECETE();
        
        public Task<MALZ_RECETE> GetMALZ_RECETEById(int id);
        
        public Task<bool> CreateMALZ_RECETEAsync(MALZ_RECETE model);
        
        public Task<bool> UpdateMALZ_RECETEAsync(MALZ_RECETE model);
 
        public Task<bool> DeleteMALZ_RECETEAsync(int ID);   
    }
}


