
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IHat_MakinalarServices
    {

        public Task<List<Hat_Makinalar>> GetHat_Makinalar();
        
        public Task<Hat_Makinalar> GetHat_MakinalarById(int id);
        
        public Task<bool> CreateHat_MakinalarAsync(Hat_Makinalar model);
        
        public Task<bool> UpdateHat_MakinalarAsync(Hat_Makinalar model);
 
        public Task<bool> DeleteHat_MakinalarAsync(int ID);   
    }
}


