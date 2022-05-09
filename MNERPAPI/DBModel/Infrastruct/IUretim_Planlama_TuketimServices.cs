
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IUretim_Planlama_TuketimServices
    {

        public Task<List<Uretim_Planlama_Tuketim>> GetUretim_Planlama_Tuketim();
        
        public Task<Uretim_Planlama_Tuketim> GetUretim_Planlama_TuketimById(int id);
        
        public Task<bool> CreateUretim_Planlama_TuketimAsync(Uretim_Planlama_Tuketim model);
        
        public Task<bool> UpdateUretim_Planlama_TuketimAsync(Uretim_Planlama_Tuketim model);
 
        public Task<bool> DeleteUretim_Planlama_TuketimAsync(int ID);   
    }
}


