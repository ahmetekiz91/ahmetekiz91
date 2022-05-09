

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class USERSServices : IUSERSServices,IDisposable
    {
        private readonly IUSERSRepository _USERSRepository;

        public USERSServices(IUSERSRepository _USERSRepository)
        {
            this._USERSRepository = _USERSRepository;
        }

        public async Task<bool> CreateUSERSAsync(USERS model)
        {
            return await _USERSRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteUSERSAsync(int ID)
        {
            return await _USERSRepository.DeleteAsync(ID);
        }

        public async Task<List<USERS>> GetUSERS()
        {
            return await _USERSRepository.GetAllAsync();
        }

        public async Task<USERS> GetUSERSById(int ID)
        {
            return await _USERSRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateUSERSAsync(USERS model)
        {
            return await _USERSRepository.UpdateAsync(model);
        }

        public void Dispose()
        {

        }
    }


}



