

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MUH_HAREKETServices : IMUH_HAREKETServices
    {
        private readonly IMUH_HAREKETRepository _MUH_HAREKETRepository;

        public  MUH_HAREKETServices(IMUH_HAREKETRepository _MUH_HAREKETRepository)
        {
            this._MUH_HAREKETRepository = _MUH_HAREKETRepository;
        }

        public async Task<bool> CreateMUH_HAREKETAsync(MUH_HAREKET model)
        {
            return await _MUH_HAREKETRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMUH_HAREKETAsync(int ID)
        {
            return await _MUH_HAREKETRepository.DeleteAsync(ID);
        }

        public async Task<List<MUH_HAREKET>> GetMUH_HAREKET()
        {
            return await _MUH_HAREKETRepository.GetAllAsync();
        }

        public async Task<MUH_HAREKET> GetMUH_HAREKETById(int ID)
        {
            return await _MUH_HAREKETRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMUH_HAREKETAsync(MUH_HAREKET model)
        {
            return await _MUH_HAREKETRepository.UpdateAsync(model);
        }
    }


}



