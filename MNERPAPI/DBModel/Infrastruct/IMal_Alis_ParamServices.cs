
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMal_Alis_ParamServices
    {

        public Task<List<Mal_Alis_Param>> GetMal_Alis_Param();
        
        public Task<Mal_Alis_Param> GetMal_Alis_ParamById(int id);
        
        public Task<bool> CreateMal_Alis_ParamAsync(Mal_Alis_Param model);
        
        public Task<bool> UpdateMal_Alis_ParamAsync(Mal_Alis_Param model);
 
        public Task<bool> DeleteMal_Alis_ParamAsync(int ID);   
    }
}


