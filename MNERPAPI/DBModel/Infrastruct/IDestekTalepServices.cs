
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IDestekTalepServices
    {

        public Task<List<DestekTalep>> GetDestekTalep();
        
        public Task<DestekTalep> GetDestekTalepById(int id);
        
        public Task<bool> CreateDestekTalepAsync(DestekTalep model);
        
        public Task<bool> UpdateDestekTalepAsync(DestekTalep model);
 
        public Task<bool> DeleteDestekTalepAsync(int ID);   
    }
}


