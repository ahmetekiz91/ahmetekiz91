

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class GiderlerServices : IGiderlerServices
    {
        private readonly IGiderlerRepository _GiderlerRepository;

        public  GiderlerServices(IGiderlerRepository _GiderlerRepository)
        {
            this._GiderlerRepository = _GiderlerRepository;
        }

        public async Task<bool> CreateGiderlerAsync(Giderler model)
        {
            return await _GiderlerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteGiderlerAsync(int ID)
        {
            return await _GiderlerRepository.DeleteAsync(ID);
        }

        public async Task<List<Giderler>> GetGiderler()
        {
            return await _GiderlerRepository.GetAllAsync();
        }

        public async Task<Giderler> GetGiderlerById(int ID)
        {
            return await _GiderlerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateGiderlerAsync(Giderler model)
        {
            return await _GiderlerRepository.UpdateAsync(model);
        }
    }


}



