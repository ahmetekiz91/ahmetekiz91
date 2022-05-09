
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMalzeme_AttributeServices
    {

        public Task<List<Malzeme_Attribute>> GetMalzeme_Attribute();
        
        public Task<Malzeme_Attribute> GetMalzeme_AttributeById(int id);
        
        public Task<bool> CreateMalzeme_AttributeAsync(Malzeme_Attribute model);
        
        public Task<bool> UpdateMalzeme_AttributeAsync(Malzeme_Attribute model);
 
        public Task<bool> DeleteMalzeme_AttributeAsync(int ID);   
    }
}


