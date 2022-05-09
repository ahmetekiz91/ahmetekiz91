

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class ANAROLLERServices : IANAROLLERServices
    {
        private readonly IANAROLLERRepository _ANAROLLERRepository;

        public  ANAROLLERServices(IANAROLLERRepository _ANAROLLERRepository)
        {
            this._ANAROLLERRepository = _ANAROLLERRepository;
        }

        public async Task<bool> CreateANAROLLERAsync(ANAROLLER model)
        {
            return await _ANAROLLERRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteANAROLLERAsync(int ID)
        {
            return await _ANAROLLERRepository.DeleteAsync(ID);
        }

        public async Task<List<ANAROLLER>> GetANAROLLER()
        {
            return await _ANAROLLERRepository.GetAllAsync();
        }

        public async Task<ANAROLLER> GetANAROLLERById(int ID)
        {
            return await _ANAROLLERRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateANAROLLERAsync(ANAROLLER model)
        {
            return await _ANAROLLERRepository.UpdateAsync(model);
        }
    }


}



