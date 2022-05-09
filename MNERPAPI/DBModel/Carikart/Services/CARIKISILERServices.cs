

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class CARIKISILERServices : ICARIKISILERServices
    {
        private readonly ICARIKISILERRepository _CARIKISILERRepository;

        public  CARIKISILERServices(ICARIKISILERRepository _CARIKISILERRepository)
        {
            this._CARIKISILERRepository = _CARIKISILERRepository;
        }

        public async Task<bool> CreateCARIKISILERAsync(CARIKISILER model)
        {
            return await _CARIKISILERRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteCARIKISILERAsync(int ID)
        {
            return await _CARIKISILERRepository.DeleteAsync(ID);
        }

        public async Task<List<CARIKISILER>> GetCARIKISILER()
        {
            return await _CARIKISILERRepository.GetAllAsync();
        }

        public async Task<CARIKISILER> GetCARIKISILERById(int ID)
        {
            return await _CARIKISILERRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateCARIKISILERAsync(CARIKISILER model)
        {
            return await _CARIKISILERRepository.UpdateAsync(model);
        }
    }


}



