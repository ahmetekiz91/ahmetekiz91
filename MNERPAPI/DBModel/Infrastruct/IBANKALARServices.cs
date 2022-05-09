
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IBANKALARServices
    {

        public Task<List<BANKALAR>> GetBANKALAR();
        
        public Task<BANKALAR> GetBANKALARById(int id);
        
        public Task<bool> CreateBANKALARAsync(BANKALAR model);
        
        public Task<bool> UpdateBANKALARAsync(BANKALAR model);
 
        public Task<bool> DeleteBANKALARAsync(int ID);   
    }
}


