

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class DuyurularServices : IDuyurularServices
    {
        private readonly IDuyurularRepository _DuyurularRepository;

        public  DuyurularServices(IDuyurularRepository _DuyurularRepository)
        {
            this._DuyurularRepository = _DuyurularRepository;
        }

        public async Task<bool> CreateDuyurularAsync(Duyurular model)
        {
            return await _DuyurularRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteDuyurularAsync(int ID)
        {
            return await _DuyurularRepository.DeleteAsync(ID);
        }

        public async Task<List<Duyurular>> GetDuyurular()
        {
            return await _DuyurularRepository.GetAllAsync();
        }

        public async Task<Duyurular> GetDuyurularById(int ID)
        {
            return await _DuyurularRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateDuyurularAsync(Duyurular model)
        {
            return await _DuyurularRepository.UpdateAsync(model);
        }
    }


}



