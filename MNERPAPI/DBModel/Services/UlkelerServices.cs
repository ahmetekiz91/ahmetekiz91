

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class UlkelerServices : IUlkelerServices
    {
        private readonly IUlkelerRepository _UlkelerRepository;

        public  UlkelerServices(IUlkelerRepository _UlkelerRepository)
        {
            this._UlkelerRepository = _UlkelerRepository;
        }

        public async Task<bool> CreateUlkelerAsync(Ulkeler model)
        {
            return await _UlkelerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteUlkelerAsync(int ID)
        {
            return await _UlkelerRepository.DeleteAsync(ID);
        }

        public async Task<List<Ulkeler>> GetUlkeler()
        {
            return await _UlkelerRepository.GetAllAsync();
        }

        public async Task<Ulkeler> GetUlkelerById(int ID)
        {
            return await _UlkelerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateUlkelerAsync(Ulkeler model)
        {
            return await _UlkelerRepository.UpdateAsync(model);
        }
    }


}



