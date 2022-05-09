
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IBORDROServices
    {

        public Task<List<BORDRO>> GetBORDRO();
        
        public Task<BORDRO> GetBORDROById(int id);
        
        public Task<bool> CreateBORDROAsync(BORDRO model);
        
        public Task<bool> UpdateBORDROAsync(BORDRO model);
 
        public Task<bool> DeleteBORDROAsync(int ID);   
    }
}


