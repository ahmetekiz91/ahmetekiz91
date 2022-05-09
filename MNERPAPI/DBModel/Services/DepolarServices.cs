

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class DepolarServices : IDepolarServices
    {
        private readonly IDepolarRepository _DepolarRepository;

        public  DepolarServices(IDepolarRepository _DepolarRepository)
        {
            this._DepolarRepository = _DepolarRepository;
        }

        public async Task<bool> CreateDepolarAsync(Depolar model)
        {
            return await _DepolarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteDepolarAsync(int ID)
        {
            return await _DepolarRepository.DeleteAsync(ID);
        }

        public async Task<List<Depolar>> GetDepolar()
        {
            return await _DepolarRepository.GetAllAsync();
        }

        public async Task<Depolar> GetDepolarById(int ID)
        {
            return await _DepolarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateDepolarAsync(Depolar model)
        {
            return await _DepolarRepository.UpdateAsync(model);
        }
    }


}



