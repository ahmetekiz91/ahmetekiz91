
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IATTRIBUTESServices
    {

        public Task<List<ATTRIBUTES>> GetATTRIBUTES();
        
        public Task<ATTRIBUTES> GetATTRIBUTESById(int id);
        
        public Task<bool> CreateATTRIBUTESAsync(ATTRIBUTES model);
        
        public Task<bool> UpdateATTRIBUTESAsync(ATTRIBUTES model);
 
        public Task<bool> DeleteATTRIBUTESAsync(int ID);   
    }
}


