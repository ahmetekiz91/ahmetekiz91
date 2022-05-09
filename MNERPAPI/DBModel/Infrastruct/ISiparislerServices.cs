
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ISiparislerServices
    {

        public Task<List<Siparisler>> GetSiparisler();
        
        public Task<Siparisler> GetSiparislerById(int id);
        
        public Task<bool> CreateSiparislerAsync(Siparisler model);
        
        public Task<bool> UpdateSiparislerAsync(Siparisler model);
 
        public Task<bool> DeleteSiparislerAsync(int ID);   
    }
}


