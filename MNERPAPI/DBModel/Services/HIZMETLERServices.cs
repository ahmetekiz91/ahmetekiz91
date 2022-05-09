

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class HIZMETLERServices : IHIZMETLERServices
    {
        private readonly IHIZMETLERRepository _HIZMETLERRepository;

        public  HIZMETLERServices(IHIZMETLERRepository _HIZMETLERRepository)
        {
            this._HIZMETLERRepository = _HIZMETLERRepository;
        }

        public async Task<bool> CreateHIZMETLERAsync(HIZMETLER model)
        {
            return await _HIZMETLERRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteHIZMETLERAsync(int ID)
        {
            return await _HIZMETLERRepository.DeleteAsync(ID);
        }

        public async Task<List<HIZMETLER>> GetHIZMETLER()
        {
            return await _HIZMETLERRepository.GetAllAsync();
        }

        public async Task<HIZMETLER> GetHIZMETLERById(int ID)
        {
            return await _HIZMETLERRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateHIZMETLERAsync(HIZMETLER model)
        {
            return await _HIZMETLERRepository.UpdateAsync(model);
        }
    }


}



