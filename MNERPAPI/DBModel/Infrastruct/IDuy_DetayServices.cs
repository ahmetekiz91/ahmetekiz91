
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IDuy_DetayServices
    {

        public Task<List<Duy_Detay>> GetDuy_Detay();
        
        public Task<Duy_Detay> GetDuy_DetayById(int id);
        
        public Task<bool> CreateDuy_DetayAsync(Duy_Detay model);
        
        public Task<bool> UpdateDuy_DetayAsync(Duy_Detay model);
 
        public Task<bool> DeleteDuy_DetayAsync(int ID);   
    }
}


