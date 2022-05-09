
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IIlcelerServices
    {

        public Task<List<Ilceler>> GetIlceler();
        
        public Task<Ilceler> GetIlcelerById(int id);
        
        public Task<bool> CreateIlcelerAsync(Ilceler model);
        
        public Task<bool> UpdateIlcelerAsync(Ilceler model);
 
        public Task<bool> DeleteIlcelerAsync(int ID);   
    }
}


