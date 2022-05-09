
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITalepler_ParamsServices
    {

        public Task<List<Talepler_Params>> GetTalepler_Params();
        
        public Task<Talepler_Params> GetTalepler_ParamsById(int id);
        
        public Task<bool> CreateTalepler_ParamsAsync(Talepler_Params model);
        
        public Task<bool> UpdateTalepler_ParamsAsync(Talepler_Params model);
 
        public Task<bool> DeleteTalepler_ParamsAsync(int ID);   
    }
}


