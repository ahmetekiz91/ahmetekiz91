
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IVardiyalarServices
    {

        public Task<List<Vardiyalar>> GetVardiyalar();
        
        public Task<Vardiyalar> GetVardiyalarById(int id);
        
        public Task<bool> CreateVardiyalarAsync(Vardiyalar model);
        
        public Task<bool> UpdateVardiyalarAsync(Vardiyalar model);
 
        public Task<bool> DeleteVardiyalarAsync(int ID);   
    }
}


