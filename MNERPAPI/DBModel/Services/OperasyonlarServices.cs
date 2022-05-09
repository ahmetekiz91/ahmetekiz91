

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class OperasyonlarServices : IOperasyonlarServices
    {
        private readonly IOperasyonlarRepository _OperasyonlarRepository;

        public  OperasyonlarServices(IOperasyonlarRepository _OperasyonlarRepository)
        {
            this._OperasyonlarRepository = _OperasyonlarRepository;
        }

        public async Task<bool> CreateOperasyonlarAsync(Operasyonlar model)
        {
            return await _OperasyonlarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteOperasyonlarAsync(int ID)
        {
            return await _OperasyonlarRepository.DeleteAsync(ID);
        }

        public async Task<List<Operasyonlar>> GetOperasyonlar()
        {
            return await _OperasyonlarRepository.GetAllAsync();
        }

        public async Task<Operasyonlar> GetOperasyonlarById(int ID)
        {
            return await _OperasyonlarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateOperasyonlarAsync(Operasyonlar model)
        {
            return await _OperasyonlarRepository.UpdateAsync(model);
        }
    }


}



