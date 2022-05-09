
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IGorev_DurumlarServices
    {

        public Task<List<Gorev_Durumlar>> GetGorev_Durumlar();
        
        public Task<Gorev_Durumlar> GetGorev_DurumlarById(int id);
        
        public Task<bool> CreateGorev_DurumlarAsync(Gorev_Durumlar model);
        
        public Task<bool> UpdateGorev_DurumlarAsync(Gorev_Durumlar model);
 
        public Task<bool> DeleteGorev_DurumlarAsync(int ID);   
    }
}


