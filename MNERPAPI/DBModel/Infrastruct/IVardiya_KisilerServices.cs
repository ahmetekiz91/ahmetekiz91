
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IVardiya_KisilerServices
    {

        public Task<List<Vardiya_Kisiler>> GetVardiya_Kisiler();
        
        public Task<Vardiya_Kisiler> GetVardiya_KisilerById(int id);
        
        public Task<bool> CreateVardiya_KisilerAsync(Vardiya_Kisiler model);
        
        public Task<bool> UpdateVardiya_KisilerAsync(Vardiya_Kisiler model);
 
        public Task<bool> DeleteVardiya_KisilerAsync(int ID);   
    }
}


