
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IBANKAHESAPLARServices
    {

        public Task<List<BANKAHESAPLAR>> GetBANKAHESAPLAR();
        
        public Task<BANKAHESAPLAR> GetBANKAHESAPLARById(int id);
        
        public Task<bool> CreateBANKAHESAPLARAsync(BANKAHESAPLAR model);
        
        public Task<bool> UpdateBANKAHESAPLARAsync(BANKAHESAPLAR model);
 
        public Task<bool> DeleteBANKAHESAPLARAsync(int ID);   
    }
}


