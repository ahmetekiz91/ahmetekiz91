
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IFIS_HAREKETServices
    {

        public Task<List<FIS_HAREKET>> GetFIS_HAREKET();
        
        public Task<FIS_HAREKET> GetFIS_HAREKETById(int id);
        
        public Task<bool> CreateFIS_HAREKETAsync(FIS_HAREKET model);
        
        public Task<bool> UpdateFIS_HAREKETAsync(FIS_HAREKET model);
 
        public Task<bool> DeleteFIS_HAREKETAsync(int ID);   
    }
}


