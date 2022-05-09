
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IBORDRO_BORCLU_KISIServices
    {

        public Task<List<BORDRO_BORCLU_KISI>> GetBORDRO_BORCLU_KISI();
        
        public Task<BORDRO_BORCLU_KISI> GetBORDRO_BORCLU_KISIById(int id);
        
        public Task<bool> CreateBORDRO_BORCLU_KISIAsync(BORDRO_BORCLU_KISI model);
        
        public Task<bool> UpdateBORDRO_BORCLU_KISIAsync(BORDRO_BORCLU_KISI model);
 
        public Task<bool> DeleteBORDRO_BORCLU_KISIAsync(int ID);   
    }
}


