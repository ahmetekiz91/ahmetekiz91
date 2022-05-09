
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ISevk_DetayServices
    {

        public Task<List<Sevk_Detay>> GetSevk_Detay();
        
        public Task<Sevk_Detay> GetSevk_DetayById(int id);
        
        public Task<bool> CreateSevk_DetayAsync(Sevk_Detay model);
        
        public Task<bool> UpdateSevk_DetayAsync(Sevk_Detay model);
 
        public Task<bool> DeleteSevk_DetayAsync(int ID);   
    }
}


