
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IOdemelerServices
    {

        public Task<List<Odemeler>> GetOdemeler();
        
        public Task<Odemeler> GetOdemelerById(int id);
        
        public Task<bool> CreateOdemelerAsync(Odemeler model);
        
        public Task<bool> UpdateOdemelerAsync(Odemeler model);
 
        public Task<bool> DeleteOdemelerAsync(int ID);   
    }
}


