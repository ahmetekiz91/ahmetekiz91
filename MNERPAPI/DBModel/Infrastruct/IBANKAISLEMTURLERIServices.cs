
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IBANKAISLEMTURLERIServices
    {

        public Task<List<BANKAISLEMTURLERI>> GetBANKAISLEMTURLERI();
        
        public Task<BANKAISLEMTURLERI> GetBANKAISLEMTURLERIById(int id);
        
        public Task<bool> CreateBANKAISLEMTURLERIAsync(BANKAISLEMTURLERI model);
        
        public Task<bool> UpdateBANKAISLEMTURLERIAsync(BANKAISLEMTURLERI model);
 
        public Task<bool> DeleteBANKAISLEMTURLERIAsync(int ID);   
    }
}


