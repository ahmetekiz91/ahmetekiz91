

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class KontrollerServices : IKontrollerServices
    {
        private readonly IKontrollerRepository _KontrollerRepository;

        public  KontrollerServices(IKontrollerRepository _KontrollerRepository)
        {
            this._KontrollerRepository = _KontrollerRepository;
        }

        public async Task<bool> CreateKontrollerAsync(Kontroller model)
        {
            return await _KontrollerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteKontrollerAsync(int ID)
        {
            return await _KontrollerRepository.DeleteAsync(ID);
        }

        public async Task<List<Kontroller>> GetKontroller()
        {
            return await _KontrollerRepository.GetAllAsync();
        }

        public async Task<Kontroller> GetKontrollerById(int ID)
        {
            return await _KontrollerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateKontrollerAsync(Kontroller model)
        {
            return await _KontrollerRepository.UpdateAsync(model);
        }
    }


}



