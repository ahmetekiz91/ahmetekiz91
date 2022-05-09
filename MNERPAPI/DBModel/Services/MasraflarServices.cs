

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MasraflarServices : IMasraflarServices
    {
        private readonly IMasraflarRepository _MasraflarRepository;

        public  MasraflarServices(IMasraflarRepository _MasraflarRepository)
        {
            this._MasraflarRepository = _MasraflarRepository;
        }

        public async Task<bool> CreateMasraflarAsync(Masraflar model)
        {
            return await _MasraflarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMasraflarAsync(int ID)
        {
            return await _MasraflarRepository.DeleteAsync(ID);
        }

        public async Task<List<Masraflar>> GetMasraflar()
        {
            return await _MasraflarRepository.GetAllAsync();
        }

        public async Task<Masraflar> GetMasraflarById(int ID)
        {
            return await _MasraflarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMasraflarAsync(Masraflar model)
        {
            return await _MasraflarRepository.UpdateAsync(model);
        }
    }


}



