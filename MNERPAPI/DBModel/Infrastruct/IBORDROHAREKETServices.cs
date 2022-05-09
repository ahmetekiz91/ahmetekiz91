
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IBORDROHAREKETServices
    {

        public Task<List<BORDROHAREKET>> GetBORDROHAREKET();
        
        public Task<BORDROHAREKET> GetBORDROHAREKETById(int id);
        
        public Task<bool> CreateBORDROHAREKETAsync(BORDROHAREKET model);
        
        public Task<bool> UpdateBORDROHAREKETAsync(BORDROHAREKET model);
 
        public Task<bool> DeleteBORDROHAREKETAsync(int ID);   
    }
}


