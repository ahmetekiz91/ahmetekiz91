
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IUretim_Planlama_UretimServices
    {

        public Task<List<Uretim_Planlama_Uretim>> GetUretim_Planlama_Uretim();
        
        public Task<Uretim_Planlama_Uretim> GetUretim_Planlama_UretimById(int id);
        
        public Task<bool> CreateUretim_Planlama_UretimAsync(Uretim_Planlama_Uretim model);
        
        public Task<bool> UpdateUretim_Planlama_UretimAsync(Uretim_Planlama_Uretim model);
 
        public Task<bool> DeleteUretim_Planlama_UretimAsync(int ID);   
    }
}


