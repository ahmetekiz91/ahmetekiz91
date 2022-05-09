
using DBModel.DTO;
using DBModel.Model;
using DBModel.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.IRepository
{
    public interface IATTRIBUTESVALUERepository : IRepository<ATTRIBUTESVALUE>
    {
        public Task<List<ATTRIBUTES>> ddl_Attribute();
        public Task<List<AttributeValuesDTO>> GetAllDTOAsync();
        public Task<AttributeValuesDTO> GetByIdDTOAsync(int ID);

    }
}

