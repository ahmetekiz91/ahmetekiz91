

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Mal_AlimServices : IMal_AlimServices
    {
        private readonly IMal_AlimRepository _Mal_AlimRepository;

        public  Mal_AlimServices(IMal_AlimRepository _Mal_AlimRepository)
        {
            this._Mal_AlimRepository = _Mal_AlimRepository;
        }

        public async Task<bool> CreateMal_AlimAsync(Mal_Alim model)
        {
            return await _Mal_AlimRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMal_AlimAsync(int ID)
        {
            return await _Mal_AlimRepository.DeleteAsync(ID);
        }

        public async Task<List<Mal_Alim>> GetMal_Alim()
        {
            return await _Mal_AlimRepository.GetAllAsync();
        }

        public async Task<Mal_Alim> GetMal_AlimById(int ID)
        {
            return await _Mal_AlimRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMal_AlimAsync(Mal_Alim model)
        {
            return await _Mal_AlimRepository.UpdateAsync(model);
        }
    }


}



