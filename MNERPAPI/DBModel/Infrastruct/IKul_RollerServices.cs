
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IKul_RollerServices
    {

        public Task<List<Kul_Roller>> GetKul_Roller();
        
        public Task<Kul_Roller> GetKul_RollerById(int id);
        
        public Task<bool> CreateKul_RollerAsync(Kul_Roller model);
        
        public Task<bool> UpdateKul_RollerAsync(Kul_Roller model);
 
        public Task<bool> DeleteKul_RollerAsync(int ID);   
    }
}


