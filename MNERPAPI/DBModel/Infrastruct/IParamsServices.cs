
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IParamsServices
    {

        public Task<List<Params>> GetParams();
        
        public Task<Params> GetParamsById(int id);
        
        public Task<bool> CreateParamsAsync(Params model);
        
        public Task<bool> UpdateParamsAsync(Params model);
 
        public Task<bool> DeleteParamsAsync(int ID);   
    }
}


