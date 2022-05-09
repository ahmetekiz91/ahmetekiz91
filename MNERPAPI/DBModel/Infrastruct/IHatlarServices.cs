
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IHatlarServices
    {

        public Task<List<Hatlar>> GetHatlar();
        
        public Task<Hatlar> GetHatlarById(int id);
        
        public Task<bool> CreateHatlarAsync(Hatlar model);
        
        public Task<bool> UpdateHatlarAsync(Hatlar model);
 
        public Task<bool> DeleteHatlarAsync(int ID);   
    }
}


