
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IPersonel_ParamsServices
    {

        public Task<List<Personel_Params>> GetPersonel_Params();
        
        public Task<Personel_Params> GetPersonel_ParamsById(int id);
        
        public Task<bool> CreatePersonel_ParamsAsync(Personel_Params model);
        
        public Task<bool> UpdatePersonel_ParamsAsync(Personel_Params model);
 
        public Task<bool> DeletePersonel_ParamsAsync(int ID);   
    }
}


