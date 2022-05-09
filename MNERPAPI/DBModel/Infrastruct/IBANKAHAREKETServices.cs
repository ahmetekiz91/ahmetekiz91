
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IBANKAHAREKETServices
    {

        public Task<List<BANKAHAREKET>> GetBANKAHAREKET();
        
        public Task<BANKAHAREKET> GetBANKAHAREKETById(int id);
        
        public Task<bool> CreateBANKAHAREKETAsync(BANKAHAREKET model);
        
        public Task<bool> UpdateBANKAHAREKETAsync(BANKAHAREKET model);
 
        public Task<bool> DeleteBANKAHAREKETAsync(int ID);   
    }
}


