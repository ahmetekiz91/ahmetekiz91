
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IPersonellerServices
    {

        public Task<List<Personeller>> GetPersoneller();
        
        public Task<Personeller> GetPersonellerById(int id);
        
        public Task<bool> CreatePersonellerAsync(Personeller model);
        
        public Task<bool> UpdatePersonellerAsync(Personeller model);
 
        public Task<bool> DeletePersonellerAsync(int ID);   
    }
}


