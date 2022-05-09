
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IBIRIMLERServices
    {

        public Task<List<BIRIMLER>> GetBIRIMLER();
        
        public Task<BIRIMLER> GetBIRIMLERById(int id);
        
        public Task<bool> CreateBIRIMLERAsync(BIRIMLER model);
        
        public Task<bool> UpdateBIRIMLERAsync(BIRIMLER model);
 
        public Task<bool> DeleteBIRIMLERAsync(int ID);   
    }
}


