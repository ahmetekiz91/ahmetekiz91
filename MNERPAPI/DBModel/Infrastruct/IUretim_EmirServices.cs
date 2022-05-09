
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IUretim_EmirServices
    {

        public Task<List<Uretim_Emir>> GetUretim_Emir();
        
        public Task<Uretim_Emir> GetUretim_EmirById(int id);
        
        public Task<bool> CreateUretim_EmirAsync(Uretim_Emir model);
        
        public Task<bool> UpdateUretim_EmirAsync(Uretim_Emir model);
 
        public Task<bool> DeleteUretim_EmirAsync(int ID);   
    }
}


