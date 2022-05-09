
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITek_Revizyon_ParamsServices
    {

        public Task<List<Tek_Revizyon_Params>> GetTek_Revizyon_Params();
        
        public Task<Tek_Revizyon_Params> GetTek_Revizyon_ParamsById(int id);
        
        public Task<bool> CreateTek_Revizyon_ParamsAsync(Tek_Revizyon_Params model);
        
        public Task<bool> UpdateTek_Revizyon_ParamsAsync(Tek_Revizyon_Params model);
 
        public Task<bool> DeleteTek_Revizyon_ParamsAsync(int ID);   
    }
}


