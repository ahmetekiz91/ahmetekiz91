
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IUretim_Planlama_Uretim_OperatorlerServices
    {

        public Task<List<Uretim_Planlama_Uretim_Operatorler>> GetUretim_Planlama_Uretim_Operatorler();
        
        public Task<Uretim_Planlama_Uretim_Operatorler> GetUretim_Planlama_Uretim_OperatorlerById(int id);
        
        public Task<bool> CreateUretim_Planlama_Uretim_OperatorlerAsync(Uretim_Planlama_Uretim_Operatorler model);
        
        public Task<bool> UpdateUretim_Planlama_Uretim_OperatorlerAsync(Uretim_Planlama_Uretim_Operatorler model);
 
        public Task<bool> DeleteUretim_Planlama_Uretim_OperatorlerAsync(int ID);   
    }
}


