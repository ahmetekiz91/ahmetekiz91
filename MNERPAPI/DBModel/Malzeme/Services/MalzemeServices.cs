

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MalzemeServices : IMalzemeServices
    {
        private readonly IMalzemeRepository _MalzemeRepository;

        public  MalzemeServices(IMalzemeRepository _MalzemeRepository)
        {
            this._MalzemeRepository = _MalzemeRepository;
        }

        public async Task<bool> CreateMalzemeAsync(Malzeme model)
        {
            return await _MalzemeRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMalzemeAsync(int ID)
        {
            return await _MalzemeRepository.DeleteAsync(ID);
        }

        public async Task<List<Malzeme>> GetMalzeme()
        {
            return await _MalzemeRepository.GetAllAsync();
        }

        public async Task<Malzeme> GetMalzemeById(int ID)
        {
            return await _MalzemeRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMalzemeAsync(Malzeme model)
        {
            return await _MalzemeRepository.UpdateAsync(model);
        }
    }


}



