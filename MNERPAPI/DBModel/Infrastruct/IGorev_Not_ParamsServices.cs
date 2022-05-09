
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IGorev_Not_ParamsServices
    {

        public Task<List<Gorev_Not_Params>> GetGorev_Not_Params();
        
        public Task<Gorev_Not_Params> GetGorev_Not_ParamsById(int id);
        
        public Task<bool> CreateGorev_Not_ParamsAsync(Gorev_Not_Params model);
        
        public Task<bool> UpdateGorev_Not_ParamsAsync(Gorev_Not_Params model);
 
        public Task<bool> DeleteGorev_Not_ParamsAsync(int ID);   
    }
}


