
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IBORDRO_TURServices
    {

        public Task<List<BORDRO_TUR>> GetBORDRO_TUR();
        
        public Task<BORDRO_TUR> GetBORDRO_TURById(int id);
        
        public Task<bool> CreateBORDRO_TURAsync(BORDRO_TUR model);
        
        public Task<bool> UpdateBORDRO_TURAsync(BORDRO_TUR model);
 
        public Task<bool> DeleteBORDRO_TURAsync(int ID);   
    }
}


