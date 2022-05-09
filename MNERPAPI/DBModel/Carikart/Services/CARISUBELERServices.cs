

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class CARISUBELERServices : ICARISUBELERServices
    {
        private readonly ICARISUBELERRepository _CARISUBELERRepository;

        public  CARISUBELERServices(ICARISUBELERRepository _CARISUBELERRepository)
        {
            this._CARISUBELERRepository = _CARISUBELERRepository;
        }

        public async Task<bool> CreateCARISUBELERAsync(CARISUBELER model)
        {
            return await _CARISUBELERRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteCARISUBELERAsync(int ID)
        {
            return await _CARISUBELERRepository.DeleteAsync(ID);
        }

        public async Task<List<CARISUBELER>> GetCARISUBELER()
        {
            return await _CARISUBELERRepository.GetAllAsync();
        }

        public async Task<CARISUBELER> GetCARISUBELERById(int ID)
        {
            return await _CARISUBELERRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateCARISUBELERAsync(CARISUBELER model)
        {
            return await _CARISUBELERRepository.UpdateAsync(model);
        }
    }


}



