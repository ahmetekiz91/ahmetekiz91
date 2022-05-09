
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMALZ_BARCODEServices
    {

        public Task<List<MALZ_BARCODE>> GetMALZ_BARCODE();
        
        public Task<MALZ_BARCODE> GetMALZ_BARCODEById(int id);
        
        public Task<bool> CreateMALZ_BARCODEAsync(MALZ_BARCODE model);
        
        public Task<bool> UpdateMALZ_BARCODEAsync(MALZ_BARCODE model);
 
        public Task<bool> DeleteMALZ_BARCODEAsync(int ID);   
    }
}


