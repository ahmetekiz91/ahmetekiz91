

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Malzeme_Recete_AttributeServices : IMalzeme_Recete_AttributeServices
    {
        private readonly IMalzeme_Recete_AttributeRepository _Malzeme_Recete_AttributeRepository;

        public  Malzeme_Recete_AttributeServices(IMalzeme_Recete_AttributeRepository _Malzeme_Recete_AttributeRepository)
        {
            this._Malzeme_Recete_AttributeRepository = _Malzeme_Recete_AttributeRepository;
        }

        public async Task<bool> CreateMalzeme_Recete_AttributeAsync(Malzeme_Recete_Attribute model)
        {
            return await _Malzeme_Recete_AttributeRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMalzeme_Recete_AttributeAsync(int ID)
        {
            return await _Malzeme_Recete_AttributeRepository.DeleteAsync(ID);
        }

        public async Task<List<Malzeme_Recete_Attribute>> GetMalzeme_Recete_Attribute()
        {
            return await _Malzeme_Recete_AttributeRepository.GetAllAsync();
        }

        public async Task<Malzeme_Recete_Attribute> GetMalzeme_Recete_AttributeById(int ID)
        {
            return await _Malzeme_Recete_AttributeRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMalzeme_Recete_AttributeAsync(Malzeme_Recete_Attribute model)
        {
            return await _Malzeme_Recete_AttributeRepository.UpdateAsync(model);
        }
    }


}



