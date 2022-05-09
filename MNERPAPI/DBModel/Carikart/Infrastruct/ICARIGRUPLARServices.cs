
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ICARIGRUPLARServices:IDisposable
    {

        public Task<List<CARIGRUPLAR>> GetCARIGRUPLAR();
        
        public Task<CARIGRUPLAR> GetCARIGRUPLARById(int id);
        
        public Task<bool> CreateCARIGRUPLARAsync(CARIGRUPLAR model);
        
        public Task<bool> UpdateCARIGRUPLARAsync(CARIGRUPLAR model);
 
        public Task<bool> DeleteCARIGRUPLARAsync(int ID);   
    }
}


