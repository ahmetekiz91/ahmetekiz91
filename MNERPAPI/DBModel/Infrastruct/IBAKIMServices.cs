
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IBAKIMServices
    {

        public Task<List<BAKIM>> GetBAKIM();
        
        public Task<BAKIM> GetBAKIMById(int id);
        
        public Task<bool> CreateBAKIMAsync(BAKIM model);
        
        public Task<bool> UpdateBAKIMAsync(BAKIM model);
 
        public Task<bool> DeleteBAKIMAsync(int ID);   
    }
}


