
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ILimanlarServices
    {

        public Task<List<Limanlar>> GetLimanlar();
        
        public Task<Limanlar> GetLimanlarById(int id);
        
        public Task<bool> CreateLimanlarAsync(Limanlar model);
        
        public Task<bool> UpdateLimanlarAsync(Limanlar model);
 
        public Task<bool> DeleteLimanlarAsync(int ID);   
    }
}


