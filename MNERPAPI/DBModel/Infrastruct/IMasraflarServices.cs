
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMasraflarServices
    {

        public Task<List<Masraflar>> GetMasraflar();
        
        public Task<Masraflar> GetMasraflarById(int id);
        
        public Task<bool> CreateMasraflarAsync(Masraflar model);
        
        public Task<bool> UpdateMasraflarAsync(Masraflar model);
 
        public Task<bool> DeleteMasraflarAsync(int ID);   
    }
}


