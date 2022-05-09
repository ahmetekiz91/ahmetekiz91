

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Malzeme_Recete_GrupServices : IMalzeme_Recete_GrupServices
    {
        private readonly IMalzeme_Recete_GrupRepository _Malzeme_Recete_GrupRepository;

        public  Malzeme_Recete_GrupServices(IMalzeme_Recete_GrupRepository _Malzeme_Recete_GrupRepository)
        {
            this._Malzeme_Recete_GrupRepository = _Malzeme_Recete_GrupRepository;
        }

        public async Task<bool> CreateMalzeme_Recete_GrupAsync(Malzeme_Recete_Grup model)
        {
            return await _Malzeme_Recete_GrupRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMalzeme_Recete_GrupAsync(int ID)
        {
            return await _Malzeme_Recete_GrupRepository.DeleteAsync(ID);
        }

        public async Task<List<Malzeme_Recete_Grup>> GetMalzeme_Recete_Grup()
        {
            return await _Malzeme_Recete_GrupRepository.GetAllAsync();
        }

        public async Task<Malzeme_Recete_Grup> GetMalzeme_Recete_GrupById(int ID)
        {
            return await _Malzeme_Recete_GrupRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMalzeme_Recete_GrupAsync(Malzeme_Recete_Grup model)
        {
            return await _Malzeme_Recete_GrupRepository.UpdateAsync(model);
        }
    }


}



