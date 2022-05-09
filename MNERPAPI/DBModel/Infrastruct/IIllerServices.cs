
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IIllerServices
    {

        public Task<List<Iller>> GetIller();
        
        public Task<Iller> GetIllerById(int id);
        
        public Task<bool> CreateIllerAsync(Iller model);
        
        public Task<bool> UpdateIllerAsync(Iller model);
 
        public Task<bool> DeleteIllerAsync(int ID);   
    }
}


