
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IFiili_Uretim_TuketimServices
    {

        public Task<List<Fiili_Uretim_Tuketim>> GetFiili_Uretim_Tuketim();
        
        public Task<Fiili_Uretim_Tuketim> GetFiili_Uretim_TuketimById(int id);
        
        public Task<bool> CreateFiili_Uretim_TuketimAsync(Fiili_Uretim_Tuketim model);
        
        public Task<bool> UpdateFiili_Uretim_TuketimAsync(Fiili_Uretim_Tuketim model);
 
        public Task<bool> DeleteFiili_Uretim_TuketimAsync(int ID);   
    }
}


