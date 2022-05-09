
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IHIZMETLERServices
    {

        public Task<List<HIZMETLER>> GetHIZMETLER();
        
        public Task<HIZMETLER> GetHIZMETLERById(int id);
        
        public Task<bool> CreateHIZMETLERAsync(HIZMETLER model);
        
        public Task<bool> UpdateHIZMETLERAsync(HIZMETLER model);
 
        public Task<bool> DeleteHIZMETLERAsync(int ID);   
    }
}


