
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITRK_Malz_AttributesServices
    {

        public Task<List<TRK_Malz_Attributes>> GetTRK_Malz_Attributes();
        
        public Task<TRK_Malz_Attributes> GetTRK_Malz_AttributesById(int id);
        
        public Task<bool> CreateTRK_Malz_AttributesAsync(TRK_Malz_Attributes model);
        
        public Task<bool> UpdateTRK_Malz_AttributesAsync(TRK_Malz_Attributes model);
 
        public Task<bool> DeleteTRK_Malz_AttributesAsync(int ID);   
    }
}


