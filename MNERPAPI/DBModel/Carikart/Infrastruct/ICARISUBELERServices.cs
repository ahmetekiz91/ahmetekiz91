
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ICARISUBELERServices
    {

        public Task<List<CARISUBELER>> GetCARISUBELER();
        
        public Task<CARISUBELER> GetCARISUBELERById(int id);
        
        public Task<bool> CreateCARISUBELERAsync(CARISUBELER model);
        
        public Task<bool> UpdateCARISUBELERAsync(CARISUBELER model);
 
        public Task<bool> DeleteCARISUBELERAsync(int ID);   
    }
}


