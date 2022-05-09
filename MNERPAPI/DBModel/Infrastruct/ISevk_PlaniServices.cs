
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ISevk_PlaniServices
    {

        public Task<List<Sevk_Plani>> GetSevk_Plani();
        
        public Task<Sevk_Plani> GetSevk_PlaniById(int id);
        
        public Task<bool> CreateSevk_PlaniAsync(Sevk_Plani model);
        
        public Task<bool> UpdateSevk_PlaniAsync(Sevk_Plani model);
 
        public Task<bool> DeleteSevk_PlaniAsync(int ID);   
    }
}


