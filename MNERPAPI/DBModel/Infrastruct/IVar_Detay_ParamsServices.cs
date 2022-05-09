
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IVar_Detay_ParamsServices
    {

        public Task<List<Var_Detay_Params>> GetVar_Detay_Params();
        
        public Task<Var_Detay_Params> GetVar_Detay_ParamsById(int id);
        
        public Task<bool> CreateVar_Detay_ParamsAsync(Var_Detay_Params model);
        
        public Task<bool> UpdateVar_Detay_ParamsAsync(Var_Detay_Params model);
 
        public Task<bool> DeleteVar_Detay_ParamsAsync(int ID);   
    }
}


