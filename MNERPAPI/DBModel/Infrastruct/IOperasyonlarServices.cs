
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IOperasyonlarServices
    {

        public Task<List<Operasyonlar>> GetOperasyonlar();
        
        public Task<Operasyonlar> GetOperasyonlarById(int id);
        
        public Task<bool> CreateOperasyonlarAsync(Operasyonlar model);
        
        public Task<bool> UpdateOperasyonlarAsync(Operasyonlar model);
 
        public Task<bool> DeleteOperasyonlarAsync(int ID);   
    }
}


