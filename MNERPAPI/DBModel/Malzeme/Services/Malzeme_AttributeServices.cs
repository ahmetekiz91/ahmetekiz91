

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Malzeme_AttributeServices : IMalzeme_AttributeServices
    {
        private readonly IMalzeme_AttributeRepository _Malzeme_AttributeRepository;

        public  Malzeme_AttributeServices(IMalzeme_AttributeRepository _Malzeme_AttributeRepository)
        {
            this._Malzeme_AttributeRepository = _Malzeme_AttributeRepository;
        }

        public async Task<bool> CreateMalzeme_AttributeAsync(Malzeme_Attribute model)
        {
            return await _Malzeme_AttributeRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMalzeme_AttributeAsync(int ID)
        {
            return await _Malzeme_AttributeRepository.DeleteAsync(ID);
        }

        public async Task<List<Malzeme_Attribute>> GetMalzeme_Attribute()
        {
            return await _Malzeme_AttributeRepository.GetAllAsync();
        }

        public async Task<Malzeme_Attribute> GetMalzeme_AttributeById(int ID)
        {
            return await _Malzeme_AttributeRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMalzeme_AttributeAsync(Malzeme_Attribute model)
        {
            return await _Malzeme_AttributeRepository.UpdateAsync(model);
        }
    }


}



