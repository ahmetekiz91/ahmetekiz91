
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ISevkiyatlarServices
    {

        public Task<List<Sevkiyatlar>> GetSevkiyatlar();
        
        public Task<Sevkiyatlar> GetSevkiyatlarById(int id);
        
        public Task<bool> CreateSevkiyatlarAsync(Sevkiyatlar model);
        
        public Task<bool> UpdateSevkiyatlarAsync(Sevkiyatlar model);
 
        public Task<bool> DeleteSevkiyatlarAsync(int ID);   
    }
}


