

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MCategoryServices : IMCategoryServices
    {
        private readonly IMCategoryRepository _MCategoryRepository;

        public  MCategoryServices(IMCategoryRepository _MCategoryRepository)
        {
            this._MCategoryRepository = _MCategoryRepository;
        }

        public async Task<bool> CreateMCategoryAsync(MCategory model)
        {
            return await _MCategoryRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMCategoryAsync(int ID)
        {
            return await _MCategoryRepository.DeleteAsync(ID);
        }

        public async Task<List<MCategory>> GetMCategory()
        {
            return await _MCategoryRepository.GetAllAsync();
        }

        public async Task<MCategory> GetMCategoryById(int ID)
        {
            return await _MCategoryRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMCategoryAsync(MCategory model)
        {
            return await _MCategoryRepository.UpdateAsync(model);
        }
    }


}



