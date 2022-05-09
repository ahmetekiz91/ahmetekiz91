
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IBIRIMDONUSUMLERIServices
    {

        public Task<List<BIRIMDONUSUMLERI>> GetBIRIMDONUSUMLERI();
        
        public Task<BIRIMDONUSUMLERI> GetBIRIMDONUSUMLERIById(int id);
        
        public Task<bool> CreateBIRIMDONUSUMLERIAsync(BIRIMDONUSUMLERI model);
        
        public Task<bool> UpdateBIRIMDONUSUMLERIAsync(BIRIMDONUSUMLERI model);
 
        public Task<bool> DeleteBIRIMDONUSUMLERIAsync(int ID);   
    }
}


