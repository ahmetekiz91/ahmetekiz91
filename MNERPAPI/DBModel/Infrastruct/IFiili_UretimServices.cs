
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IFiili_UretimServices
    {

        public Task<List<Fiili_Uretim>> GetFiili_Uretim();
        
        public Task<Fiili_Uretim> GetFiili_UretimById(int id);
        
        public Task<bool> CreateFiili_UretimAsync(Fiili_Uretim model);
        
        public Task<bool> UpdateFiili_UretimAsync(Fiili_Uretim model);
 
        public Task<bool> DeleteFiili_UretimAsync(int ID);   
    }
}


