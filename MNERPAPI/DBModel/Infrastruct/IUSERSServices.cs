
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IUSERSServices: IDisposable
    {

        public Task<List<USERS>> GetUSERS();
        
        public Task<USERS> GetUSERSById(int id);
        
        public Task<bool> CreateUSERSAsync(USERS model);
        
        public Task<bool> UpdateUSERSAsync(USERS model);
 
        public Task<bool> DeleteUSERSAsync(int ID);   
    }
}


