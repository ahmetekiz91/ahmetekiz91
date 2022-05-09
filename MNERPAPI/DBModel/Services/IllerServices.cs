

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class IllerServices : IIllerServices
    {
        private readonly IIllerRepository _IllerRepository;

        public  IllerServices(IIllerRepository _IllerRepository)
        {
            this._IllerRepository = _IllerRepository;
        }

        public async Task<bool> CreateIllerAsync(Iller model)
        {
            return await _IllerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteIllerAsync(int ID)
        {
            return await _IllerRepository.DeleteAsync(ID);
        }

        public async Task<List<Iller>> GetIller()
        {
            return await _IllerRepository.GetAllAsync();
        }

        public async Task<Iller> GetIllerById(int ID)
        {
            return await _IllerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateIllerAsync(Iller model)
        {
            return await _IllerRepository.UpdateAsync(model);
        }
    }


}



