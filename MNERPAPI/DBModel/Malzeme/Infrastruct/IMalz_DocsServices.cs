
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMalz_DocsServices
    {

        public Task<List<Malz_Docs>> GetMalz_Docs();
        
        public Task<Malz_Docs> GetMalz_DocsById(int id);
        
        public Task<bool> CreateMalz_DocsAsync(Malz_Docs model);
        
        public Task<bool> UpdateMalz_DocsAsync(Malz_Docs model);
 
        public Task<bool> DeleteMalz_DocsAsync(int ID);   
    }
}


