
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITalep_DetayServices
    {

        public Task<List<Talep_Detay>> GetTalep_Detay();
        
        public Task<Talep_Detay> GetTalep_DetayById(int id);
        
        public Task<bool> CreateTalep_DetayAsync(Talep_Detay model);
        
        public Task<bool> UpdateTalep_DetayAsync(Talep_Detay model);
 
        public Task<bool> DeleteTalep_DetayAsync(int ID);   
    }
}


