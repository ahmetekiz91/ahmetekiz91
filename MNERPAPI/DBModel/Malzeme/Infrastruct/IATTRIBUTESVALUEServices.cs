
using DBModel.DTO;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IATTRIBUTESVALUEServices
    {

        public Task<List<AttributeValuesDTO>> GetATTRIBUTESVALUE();
        
        public Task<AttributeValuesDTO> GetATTRIBUTESVALUEById(int id);
        
        public Task<bool> CreateATTRIBUTESVALUEAsync(AttributeValuesDTO model);
        
        public Task<bool> UpdateATTRIBUTESVALUEAsync(AttributeValuesDTO model);
 
        public Task<bool> DeleteATTRIBUTESVALUEAsync(int ID);
        public Task<List<ATTRIBUTES>> ddl_Attribute();
    }
}


