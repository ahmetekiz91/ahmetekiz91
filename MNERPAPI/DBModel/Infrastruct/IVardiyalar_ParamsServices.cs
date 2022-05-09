
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IVardiyalar_ParamsServices
    {

        public Task<List<Vardiyalar_Params>> GetVardiyalar_Params();
        
        public Task<Vardiyalar_Params> GetVardiyalar_ParamsById(int id);
        
        public Task<bool> CreateVardiyalar_ParamsAsync(Vardiyalar_Params model);
        
        public Task<bool> UpdateVardiyalar_ParamsAsync(Vardiyalar_Params model);
 
        public Task<bool> DeleteVardiyalar_ParamsAsync(int ID);   
    }
}


