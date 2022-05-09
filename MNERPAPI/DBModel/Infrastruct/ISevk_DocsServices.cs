
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ISevk_DocsServices
    {

        public Task<List<Sevk_Docs>> GetSevk_Docs();
        
        public Task<Sevk_Docs> GetSevk_DocsById(int id);
        
        public Task<bool> CreateSevk_DocsAsync(Sevk_Docs model);
        
        public Task<bool> UpdateSevk_DocsAsync(Sevk_Docs model);
 
        public Task<bool> DeleteSevk_DocsAsync(int ID);   
    }
}


