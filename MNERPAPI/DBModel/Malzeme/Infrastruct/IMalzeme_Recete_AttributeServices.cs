
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMalzeme_Recete_AttributeServices
    {

        public Task<List<Malzeme_Recete_Attribute>> GetMalzeme_Recete_Attribute();
        
        public Task<Malzeme_Recete_Attribute> GetMalzeme_Recete_AttributeById(int id);
        
        public Task<bool> CreateMalzeme_Recete_AttributeAsync(Malzeme_Recete_Attribute model);
        
        public Task<bool> UpdateMalzeme_Recete_AttributeAsync(Malzeme_Recete_Attribute model);
 
        public Task<bool> DeleteMalzeme_Recete_AttributeAsync(int ID);   
    }
}


