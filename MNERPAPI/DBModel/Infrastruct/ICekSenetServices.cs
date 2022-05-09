
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ICekSenetServices
    {

        public Task<List<CekSenet>> GetCekSenet();
        
        public Task<CekSenet> GetCekSenetById(int id);
        
        public Task<bool> CreateCekSenetAsync(CekSenet model);
        
        public Task<bool> UpdateCekSenetAsync(CekSenet model);
 
        public Task<bool> DeleteCekSenetAsync(int ID);   
    }
}


