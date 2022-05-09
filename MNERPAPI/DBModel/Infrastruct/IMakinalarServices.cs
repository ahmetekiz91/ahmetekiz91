
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMakinalarServices
    {

        public Task<List<Makinalar>> GetMakinalar();
        
        public Task<Makinalar> GetMakinalarById(int id);
        
        public Task<bool> CreateMakinalarAsync(Makinalar model);
        
        public Task<bool> UpdateMakinalarAsync(Makinalar model);
 
        public Task<bool> DeleteMakinalarAsync(int ID);   
    }
}


