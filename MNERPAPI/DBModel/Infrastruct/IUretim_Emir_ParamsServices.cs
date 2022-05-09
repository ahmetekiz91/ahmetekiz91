
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IUretim_Emir_ParamsServices
    {

        public Task<List<Uretim_Emir_Params>> GetUretim_Emir_Params();
        
        public Task<Uretim_Emir_Params> GetUretim_Emir_ParamsById(int id);
        
        public Task<bool> CreateUretim_Emir_ParamsAsync(Uretim_Emir_Params model);
        
        public Task<bool> UpdateUretim_Emir_ParamsAsync(Uretim_Emir_Params model);
 
        public Task<bool> DeleteUretim_Emir_ParamsAsync(int ID);   
    }
}


