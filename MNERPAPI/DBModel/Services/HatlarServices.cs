

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class HatlarServices : IHatlarServices
    {
        private readonly IHatlarRepository _HatlarRepository;

        public  HatlarServices(IHatlarRepository _HatlarRepository)
        {
            this._HatlarRepository = _HatlarRepository;
        }

        public async Task<bool> CreateHatlarAsync(Hatlar model)
        {
            return await _HatlarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteHatlarAsync(int ID)
        {
            return await _HatlarRepository.DeleteAsync(ID);
        }

        public async Task<List<Hatlar>> GetHatlar()
        {
            return await _HatlarRepository.GetAllAsync();
        }

        public async Task<Hatlar> GetHatlarById(int ID)
        {
            return await _HatlarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateHatlarAsync(Hatlar model)
        {
            return await _HatlarRepository.UpdateAsync(model);
        }
    }


}



