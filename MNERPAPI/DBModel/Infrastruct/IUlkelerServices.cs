
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IUlkelerServices
    {

        public Task<List<Ulkeler>> GetUlkeler();
        
        public Task<Ulkeler> GetUlkelerById(int id);
        
        public Task<bool> CreateUlkelerAsync(Ulkeler model);
        
        public Task<bool> UpdateUlkelerAsync(Ulkeler model);
 
        public Task<bool> DeleteUlkelerAsync(int ID);   
    }
}


