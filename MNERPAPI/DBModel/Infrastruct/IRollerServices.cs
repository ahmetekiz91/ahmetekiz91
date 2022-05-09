
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IRollerServices
    {

        public Task<List<Roller>> GetRoller();
        
        public Task<Roller> GetRollerById(int id);
        
        public Task<bool> CreateRollerAsync(Roller model);
        
        public Task<bool> UpdateRollerAsync(Roller model);
 
        public Task<bool> DeleteRollerAsync(int ID);   
    }
}


