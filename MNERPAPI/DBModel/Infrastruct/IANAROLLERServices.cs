
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IANAROLLERServices
    {

        public Task<List<ANAROLLER>> GetANAROLLER();
        
        public Task<ANAROLLER> GetANAROLLERById(int id);
        
        public Task<bool> CreateANAROLLERAsync(ANAROLLER model);
        
        public Task<bool> UpdateANAROLLERAsync(ANAROLLER model);
 
        public Task<bool> DeleteANAROLLERAsync(int ID);   
    }
}


