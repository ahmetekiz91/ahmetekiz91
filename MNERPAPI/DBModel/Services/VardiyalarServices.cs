

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class VardiyalarServices : IVardiyalarServices
    {
        private readonly IVardiyalarRepository _VardiyalarRepository;

        public  VardiyalarServices(IVardiyalarRepository _VardiyalarRepository)
        {
            this._VardiyalarRepository = _VardiyalarRepository;
        }

        public async Task<bool> CreateVardiyalarAsync(Vardiyalar model)
        {
            return await _VardiyalarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteVardiyalarAsync(int ID)
        {
            return await _VardiyalarRepository.DeleteAsync(ID);
        }

        public async Task<List<Vardiyalar>> GetVardiyalar()
        {
            return await _VardiyalarRepository.GetAllAsync();
        }

        public async Task<Vardiyalar> GetVardiyalarById(int ID)
        {
            return await _VardiyalarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateVardiyalarAsync(Vardiyalar model)
        {
            return await _VardiyalarRepository.UpdateAsync(model);
        }
    }


}



