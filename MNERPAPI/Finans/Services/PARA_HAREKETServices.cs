using FINANS.Infrastruce;
using FINANS.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBModel.IRepository;
using FINANS.Model;

namespace FINANS.Services
{
    public class PARA_HAREKETServices : IPARA_HAREKETServices
    {
        private readonly IPARA_HAREKETRepository _PARA_HAREKETRepository;

        public  PARA_HAREKETServices(IPARA_HAREKETRepository _PARA_HAREKETRepository)
        {
            this._PARA_HAREKETRepository = _PARA_HAREKETRepository;
        }

        public async Task<bool> CreatePARA_HAREKETAsync(PARA_HAREKET model)
        {
            return await _PARA_HAREKETRepository.CreateAsync(model);
        }

        public async Task<bool> DeletePARA_HAREKETAsync(int ID)
        {
            return await _PARA_HAREKETRepository.DeleteAsync(ID);
        }

        public async Task<List<PARA_HAREKET>> GetPARA_HAREKET()
        {
            return await _PARA_HAREKETRepository.GetAllAsync();
        }

        public async Task<PARA_HAREKET> GetPARA_HAREKETById(int ID)
        {
            return await _PARA_HAREKETRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdatePARA_HAREKETAsync(PARA_HAREKET model)
        {
            return await _PARA_HAREKETRepository.UpdateAsync(model);
        }
    }
}