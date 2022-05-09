
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMUH_KODLARIServices
    {

        public Task<List<MUH_KODLARI>> GetMUH_KODLARI();
        
        public Task<MUH_KODLARI> GetMUH_KODLARIById(int id);
        
        public Task<bool> CreateMUH_KODLARIAsync(MUH_KODLARI model);
        
        public Task<bool> UpdateMUH_KODLARIAsync(MUH_KODLARI model);
 
        public Task<bool> DeleteMUH_KODLARIAsync(int ID);   
    }
}


