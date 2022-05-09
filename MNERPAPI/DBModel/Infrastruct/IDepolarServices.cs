
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IDepolarServices
    {

        public Task<List<Depolar>> GetDepolar();
        
        public Task<Depolar> GetDepolarById(int id);
        
        public Task<bool> CreateDepolarAsync(Depolar model);
        
        public Task<bool> UpdateDepolarAsync(Depolar model);
 
        public Task<bool> DeleteDepolarAsync(int ID);   
    }
}


