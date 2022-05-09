
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ICARIHAREKETServices
    {

        public Task<List<CARIHAREKET>> GetCARIHAREKET();
        
        public Task<CARIHAREKET> GetCARIHAREKETById(int id);
        
        public Task<bool> CreateCARIHAREKETAsync(CARIHAREKET model);
       
        public Task<bool> UpdateCARIHAREKETAsync(CARIHAREKET model);
 
        public Task<bool> DeleteCARIHAREKETAsync(int ID);   
    }
}


