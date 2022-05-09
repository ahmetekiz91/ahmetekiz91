

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class DestekTalepServices : IDestekTalepServices
    {
        private readonly IDestekTalepRepository _DestekTalepRepository;

        public  DestekTalepServices(IDestekTalepRepository _DestekTalepRepository)
        {
            this._DestekTalepRepository = _DestekTalepRepository;
        }

        public async Task<bool> CreateDestekTalepAsync(DestekTalep model)
        {
            return await _DestekTalepRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteDestekTalepAsync(int ID)
        {
            return await _DestekTalepRepository.DeleteAsync(ID);
        }

        public async Task<List<DestekTalep>> GetDestekTalep()
        {
            return await _DestekTalepRepository.GetAllAsync();
        }

        public async Task<DestekTalep> GetDestekTalepById(int ID)
        {
            return await _DestekTalepRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateDestekTalepAsync(DestekTalep model)
        {
            return await _DestekTalepRepository.UpdateAsync(model);
        }
    }


}



