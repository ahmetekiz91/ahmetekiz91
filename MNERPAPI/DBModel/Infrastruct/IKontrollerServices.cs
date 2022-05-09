
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IKontrollerServices
    {

        public Task<List<Kontroller>> GetKontroller();
        
        public Task<Kontroller> GetKontrollerById(int id);
        
        public Task<bool> CreateKontrollerAsync(Kontroller model);
        
        public Task<bool> UpdateKontrollerAsync(Kontroller model);
 
        public Task<bool> DeleteKontrollerAsync(int ID);   
    }
}


