
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ICARIKISILERServices
    {

        public Task<List<CARIKISILER>> GetCARIKISILER();
        
        public Task<CARIKISILER> GetCARIKISILERById(int id);
        
        public Task<bool> CreateCARIKISILERAsync(CARIKISILER model);
        
        public Task<bool> UpdateCARIKISILERAsync(CARIKISILER model);
 
        public Task<bool> DeleteCARIKISILERAsync(int ID);   
    }
}


