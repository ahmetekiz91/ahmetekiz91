

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MakinalarServices : IMakinalarServices
    {
        private readonly IMakinalarRepository _MakinalarRepository;

        public  MakinalarServices(IMakinalarRepository _MakinalarRepository)
        {
            this._MakinalarRepository = _MakinalarRepository;
        }

        public async Task<bool> CreateMakinalarAsync(Makinalar model)
        {
            return await _MakinalarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMakinalarAsync(int ID)
        {
            return await _MakinalarRepository.DeleteAsync(ID);
        }

        public async Task<List<Makinalar>> GetMakinalar()
        {
            return await _MakinalarRepository.GetAllAsync();
        }

        public async Task<Makinalar> GetMakinalarById(int ID)
        {
            return await _MakinalarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMakinalarAsync(Makinalar model)
        {
            return await _MakinalarRepository.UpdateAsync(model);
        }
    }


}



