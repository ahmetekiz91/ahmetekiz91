

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class KasalarServices : IKasalarServices
    {
        private readonly IKasalarRepository _KasalarRepository;

        public  KasalarServices(IKasalarRepository _KasalarRepository)
        {
            this._KasalarRepository = _KasalarRepository;
        }

        public async Task<bool> CreateKasalarAsync(Kasalar model)
        {
            return await _KasalarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteKasalarAsync(int ID)
        {
            return await _KasalarRepository.DeleteAsync(ID);
        }

        public async Task<List<Kasalar>> GetKasalar()
        {
            return await _KasalarRepository.GetAllAsync();
        }

        public async Task<Kasalar> GetKasalarById(int ID)
        {
            return await _KasalarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateKasalarAsync(Kasalar model)
        {
            return await _KasalarRepository.UpdateAsync(model);
        }
    }


}



