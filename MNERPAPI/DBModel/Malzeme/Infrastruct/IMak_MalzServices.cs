
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMak_MalzServices
    {

        public Task<List<Mak_Malz>> GetMak_Malz();
        
        public Task<Mak_Malz> GetMak_MalzById(int id);
        
        public Task<bool> CreateMak_MalzAsync(Mak_Malz model);
        
        public Task<bool> UpdateMak_MalzAsync(Mak_Malz model);
 
        public Task<bool> DeleteMak_MalzAsync(int ID);   
    }
}


