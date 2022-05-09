
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMALZ_BIRIMServices
    {

        public Task<List<MALZ_BIRIM>> GetMALZ_BIRIM();
        
        public Task<MALZ_BIRIM> GetMALZ_BIRIMById(int id);
        
        public Task<bool> CreateMALZ_BIRIMAsync(MALZ_BIRIM model);
        
        public Task<bool> UpdateMALZ_BIRIMAsync(MALZ_BIRIM model);
 
        public Task<bool> DeleteMALZ_BIRIMAsync(int ID);   
    }
}


