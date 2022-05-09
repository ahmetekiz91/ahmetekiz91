
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITaleplerServices
    {

        public Task<List<Talepler>> GetTalepler();
        
        public Task<Talepler> GetTaleplerById(int id);
        
        public Task<bool> CreateTaleplerAsync(Talepler model);
        
        public Task<bool> UpdateTaleplerAsync(Talepler model);
 
        public Task<bool> DeleteTaleplerAsync(int ID);   
    }
}


