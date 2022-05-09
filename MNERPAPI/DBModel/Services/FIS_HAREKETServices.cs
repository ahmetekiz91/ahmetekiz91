

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class FIS_HAREKETServices : IFIS_HAREKETServices
    {
        private readonly IFIS_HAREKETRepository _FIS_HAREKETRepository;

        public  FIS_HAREKETServices(IFIS_HAREKETRepository _FIS_HAREKETRepository)
        {
            this._FIS_HAREKETRepository = _FIS_HAREKETRepository;
        }

        public async Task<bool> CreateFIS_HAREKETAsync(FIS_HAREKET model)
        {
            return await _FIS_HAREKETRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteFIS_HAREKETAsync(int ID)
        {
            return await _FIS_HAREKETRepository.DeleteAsync(ID);
        }

        public async Task<List<FIS_HAREKET>> GetFIS_HAREKET()
        {
            return await _FIS_HAREKETRepository.GetAllAsync();
        }

        public async Task<FIS_HAREKET> GetFIS_HAREKETById(int ID)
        {
            return await _FIS_HAREKETRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateFIS_HAREKETAsync(FIS_HAREKET model)
        {
            return await _FIS_HAREKETRepository.UpdateAsync(model);
        }
    }


}



