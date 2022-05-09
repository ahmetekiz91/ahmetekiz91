

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class OdemelerServices : IOdemelerServices
    {
        private readonly IOdemelerRepository _OdemelerRepository;

        public  OdemelerServices(IOdemelerRepository _OdemelerRepository)
        {
            this._OdemelerRepository = _OdemelerRepository;
        }

        public async Task<bool> CreateOdemelerAsync(Odemeler model)
        {
            return await _OdemelerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteOdemelerAsync(int ID)
        {
            return await _OdemelerRepository.DeleteAsync(ID);
        }

        public async Task<List<Odemeler>> GetOdemeler()
        {
            return await _OdemelerRepository.GetAllAsync();
        }

        public async Task<Odemeler> GetOdemelerById(int ID)
        {
            return await _OdemelerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateOdemelerAsync(Odemeler model)
        {
            return await _OdemelerRepository.UpdateAsync(model);
        }
    }


}



