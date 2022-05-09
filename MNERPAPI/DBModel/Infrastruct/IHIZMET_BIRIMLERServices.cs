
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IHIZMET_BIRIMLERServices
    {

        public Task<List<HIZMET_BIRIMLER>> GetHIZMET_BIRIMLER();
        
        public Task<HIZMET_BIRIMLER> GetHIZMET_BIRIMLERById(int id);
        
        public Task<bool> CreateHIZMET_BIRIMLERAsync(HIZMET_BIRIMLER model);
        
        public Task<bool> UpdateHIZMET_BIRIMLERAsync(HIZMET_BIRIMLER model);
 
        public Task<bool> DeleteHIZMET_BIRIMLERAsync(int ID);   
    }
}


