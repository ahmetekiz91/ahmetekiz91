

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class BAKIMServices : IBAKIMServices
    {

        private readonly IBAKIMRepository _BAKIMRepository;

        public  BAKIMServices(IBAKIMRepository _BAKIMRepository)
        {
            this._BAKIMRepository = _BAKIMRepository;
        }

        public async Task<bool> CreateBAKIMAsync(BAKIM model)
        {
            return await _BAKIMRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteBAKIMAsync(int ID)
        {
            return await _BAKIMRepository.DeleteAsync(ID);
        }

        public async Task<List<BAKIM>> GetBAKIM()
        {
            return await _BAKIMRepository.GetAllAsync();
        }

        public async Task<BAKIM> GetBAKIMById(int ID)
        {
            return await _BAKIMRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateBAKIMAsync(BAKIM model)
        {
            return await _BAKIMRepository.UpdateAsync(model);
        }

    }
}



