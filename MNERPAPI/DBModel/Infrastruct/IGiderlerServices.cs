
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IGiderlerServices
    {

        public Task<List<Giderler>> GetGiderler();
        
        public Task<Giderler> GetGiderlerById(int id);
        
        public Task<bool> CreateGiderlerAsync(Giderler model);
        
        public Task<bool> UpdateGiderlerAsync(Giderler model);
 
        public Task<bool> DeleteGiderlerAsync(int ID);   
    }
}


