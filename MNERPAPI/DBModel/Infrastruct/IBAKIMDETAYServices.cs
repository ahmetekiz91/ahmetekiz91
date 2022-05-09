
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IBAKIMDETAYServices
    {

        public Task<List<BAKIMDETAY>> GetBAKIMDETAY();
        
        public Task<BAKIMDETAY> GetBAKIMDETAYById(int id);
        
        public Task<bool> CreateBAKIMDETAYAsync(BAKIMDETAY model);
        
        public Task<bool> UpdateBAKIMDETAYAsync(BAKIMDETAY model);
 
        public Task<bool> DeleteBAKIMDETAYAsync(int ID);   
    }
}


