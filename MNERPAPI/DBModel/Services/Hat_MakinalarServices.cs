

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Hat_MakinalarServices : IHat_MakinalarServices
    {
        private readonly IHat_MakinalarRepository _Hat_MakinalarRepository;

        public  Hat_MakinalarServices(IHat_MakinalarRepository _Hat_MakinalarRepository)
        {
            this._Hat_MakinalarRepository = _Hat_MakinalarRepository;
        }

        public async Task<bool> CreateHat_MakinalarAsync(Hat_Makinalar model)
        {
            return await _Hat_MakinalarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteHat_MakinalarAsync(int ID)
        {
            return await _Hat_MakinalarRepository.DeleteAsync(ID);
        }

        public async Task<List<Hat_Makinalar>> GetHat_Makinalar()
        {
            return await _Hat_MakinalarRepository.GetAllAsync();
        }

        public async Task<Hat_Makinalar> GetHat_MakinalarById(int ID)
        {
            return await _Hat_MakinalarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateHat_MakinalarAsync(Hat_Makinalar model)
        {
            return await _Hat_MakinalarRepository.UpdateAsync(model);
        }
    }


}



