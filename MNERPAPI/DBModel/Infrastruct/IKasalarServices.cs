
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IKasalarServices
    {

        public Task<List<Kasalar>> GetKasalar();
        
        public Task<Kasalar> GetKasalarById(int id);
        
        public Task<bool> CreateKasalarAsync(Kasalar model);
        
        public Task<bool> UpdateKasalarAsync(Kasalar model);
 
        public Task<bool> DeleteKasalarAsync(int ID);   
    }
}


