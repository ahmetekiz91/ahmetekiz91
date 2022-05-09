

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class SevkiyatlarServices : ISevkiyatlarServices
    {
        private readonly ISevkiyatlarRepository _SevkiyatlarRepository;

        public  SevkiyatlarServices(ISevkiyatlarRepository _SevkiyatlarRepository)
        {
            this._SevkiyatlarRepository = _SevkiyatlarRepository;
        }

        public async Task<bool> CreateSevkiyatlarAsync(Sevkiyatlar model)
        {
            return await _SevkiyatlarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteSevkiyatlarAsync(int ID)
        {
            return await _SevkiyatlarRepository.DeleteAsync(ID);
        }

        public async Task<List<Sevkiyatlar>> GetSevkiyatlar()
        {
            return await _SevkiyatlarRepository.GetAllAsync();
        }

        public async Task<Sevkiyatlar> GetSevkiyatlarById(int ID)
        {
            return await _SevkiyatlarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateSevkiyatlarAsync(Sevkiyatlar model)
        {
            return await _SevkiyatlarRepository.UpdateAsync(model);
        }
    }


}



