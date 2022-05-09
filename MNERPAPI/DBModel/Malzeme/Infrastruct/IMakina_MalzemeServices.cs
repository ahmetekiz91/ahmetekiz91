
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMakina_MalzemeServices
    {

        public Task<List<Makina_Malzeme>> GetMakina_Malzeme();
        
        public Task<Makina_Malzeme> GetMakina_MalzemeById(int id);
        
        public Task<bool> CreateMakina_MalzemeAsync(Makina_Malzeme model);
        
        public Task<bool> UpdateMakina_MalzemeAsync(Makina_Malzeme model);
 
        public Task<bool> DeleteMakina_MalzemeAsync(int ID);   
    }
}


