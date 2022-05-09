

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Makina_MalzemeServices : IMakina_MalzemeServices
    {
        private readonly IMakina_MalzemeRepository _Makina_MalzemeRepository;

        public  Makina_MalzemeServices(IMakina_MalzemeRepository _Makina_MalzemeRepository)
        {
            this._Makina_MalzemeRepository = _Makina_MalzemeRepository;
        }

        public async Task<bool> CreateMakina_MalzemeAsync(Makina_Malzeme model)
        {
            return await _Makina_MalzemeRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMakina_MalzemeAsync(int ID)
        {
            return await _Makina_MalzemeRepository.DeleteAsync(ID);
        }

        public async Task<List<Makina_Malzeme>> GetMakina_Malzeme()
        {
            return await _Makina_MalzemeRepository.GetAllAsync();
        }

        public async Task<Makina_Malzeme> GetMakina_MalzemeById(int ID)
        {
            return await _Makina_MalzemeRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMakina_MalzemeAsync(Makina_Malzeme model)
        {
            return await _Makina_MalzemeRepository.UpdateAsync(model);
        }
    }


}



