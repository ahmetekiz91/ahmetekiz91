
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IFISLERServices: IDisposable
    {

        public Task<List<FISLER>> GetFISLER();
        
        public Task<FISLER> GetFISLERById(int id);
        
        public Task<bool> CreateFISLERAsync(FISLER model);
        

        public Task<bool> UpdateFISLERAsync(FISLER model);
 
        public Task<bool> DeleteFISLERAsync(int ID);   
    }
}


