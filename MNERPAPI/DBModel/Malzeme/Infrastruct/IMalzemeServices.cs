
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMalzemeServices
    {

        public Task<List<Malzeme>> GetMalzeme();
        
        public Task<Malzeme> GetMalzemeById(int id);
        
        public Task<bool> CreateMalzemeAsync(Malzeme model);
        
        public Task<bool> UpdateMalzemeAsync(Malzeme model);
 
        public Task<bool> DeleteMalzemeAsync(int ID);   
    }
}


