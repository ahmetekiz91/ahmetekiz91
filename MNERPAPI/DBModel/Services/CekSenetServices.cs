

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class CekSenetServices : ICekSenetServices
    {
        private readonly ICekSenetRepository _CekSenetRepository;

        public  CekSenetServices(ICekSenetRepository _CekSenetRepository)
        {
            this._CekSenetRepository = _CekSenetRepository;
        }

        public async Task<bool> CreateCekSenetAsync(CekSenet model)
        {
            return await _CekSenetRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteCekSenetAsync(int ID)
        {
            return await _CekSenetRepository.DeleteAsync(ID);
        }

        public async Task<List<CekSenet>> GetCekSenet()
        {
            return await _CekSenetRepository.GetAllAsync();
        }

        public async Task<CekSenet> GetCekSenetById(int ID)
        {
            return await _CekSenetRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateCekSenetAsync(CekSenet model)
        {
            return await _CekSenetRepository.UpdateAsync(model);
        }
    }


}



