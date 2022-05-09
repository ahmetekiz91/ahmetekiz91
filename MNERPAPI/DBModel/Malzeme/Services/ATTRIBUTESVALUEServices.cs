using AutoMapper;
using Dapper;
using DBModel.DTO;
using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using DBModel.Utility;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    //DTO dönen methodlar ve map eden objeler bu katmanda yapılacak
    //auto mapper lazım
    public class ATTRIBUTESVALUEServices :  IATTRIBUTESVALUEServices
    {

        private readonly IMapper mapper;

        private readonly IATTRIBUTESVALUERepository _ATTRIBUTESVALUERepository;

        public  ATTRIBUTESVALUEServices(IATTRIBUTESVALUERepository _ATTRIBUTESVALUERepository,IMapper mapper)
        {
            this._ATTRIBUTESVALUERepository = _ATTRIBUTESVALUERepository;
            this.mapper = mapper;
        }

        public async Task<bool> CreateATTRIBUTESVALUEAsync(AttributeValuesDTO model)
        {
            ATTRIBUTESVALUE m = new ATTRIBUTESVALUE();
            m = mapper.Map<ATTRIBUTESVALUE>(model);
            return await _ATTRIBUTESVALUERepository.CreateAsync(m);
        }

        public async Task<bool> DeleteATTRIBUTESVALUEAsync(int ID)
        {
            return await _ATTRIBUTESVALUERepository.DeleteAsync(ID);
        }

        public async Task<List<AttributeValuesDTO>> GetATTRIBUTESVALUE()
        {
           
            return  await _ATTRIBUTESVALUERepository.GetAllDTOAsync();
        }

        public async Task<AttributeValuesDTO> GetATTRIBUTESVALUEById(int ID)
        {
            return await _ATTRIBUTESVALUERepository.GetByIdDTOAsync(ID);
        }

        public async Task<bool> UpdateATTRIBUTESVALUEAsync(AttributeValuesDTO model)
        {
            ATTRIBUTESVALUE m = new ATTRIBUTESVALUE();
            m = mapper.Map<ATTRIBUTESVALUE>(model);
            return await _ATTRIBUTESVALUERepository.UpdateAsync(m);
        }


        public async Task<List<ATTRIBUTES>> ddl_Attribute()
        {
            return await _ATTRIBUTESVALUERepository.ddl_Attribute();
        }
    }
}