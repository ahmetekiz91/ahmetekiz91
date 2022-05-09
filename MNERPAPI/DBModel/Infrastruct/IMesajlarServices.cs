
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMesajlarServices
    {

        public Task<List<Mesajlar>> GetMesajlar();
        
        public Task<Mesajlar> GetMesajlarById(int id);
        
        public Task<bool> CreateMesajlarAsync(Mesajlar model);
        
        public Task<bool> UpdateMesajlarAsync(Mesajlar model);
 
        public Task<bool> DeleteMesajlarAsync(int ID);   
    }
}


