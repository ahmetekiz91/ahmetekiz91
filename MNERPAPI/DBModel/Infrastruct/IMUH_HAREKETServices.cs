
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMUH_HAREKETServices
    {

        public Task<List<MUH_HAREKET>> GetMUH_HAREKET();
        
        public Task<MUH_HAREKET> GetMUH_HAREKETById(int id);
        
        public Task<bool> CreateMUH_HAREKETAsync(MUH_HAREKET model);
        
        public Task<bool> UpdateMUH_HAREKETAsync(MUH_HAREKET model);
 
        public Task<bool> DeleteMUH_HAREKETAsync(int ID);   
    }
}


