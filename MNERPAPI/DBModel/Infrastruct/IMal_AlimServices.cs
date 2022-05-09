
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMal_AlimServices
    {

        public Task<List<Mal_Alim>> GetMal_Alim();
        
        public Task<Mal_Alim> GetMal_AlimById(int id);
        
        public Task<bool> CreateMal_AlimAsync(Mal_Alim model);
        
        public Task<bool> UpdateMal_AlimAsync(Mal_Alim model);
 
        public Task<bool> DeleteMal_AlimAsync(int ID);   
    }
}


