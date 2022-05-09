

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class BANKALARServices : IBANKALARServices
    {
        private readonly IBANKALARRepository _BANKALARRepository;

        public  BANKALARServices(IBANKALARRepository _BANKALARRepository)
        {
            this._BANKALARRepository = _BANKALARRepository;
        }

        public async Task<bool> CreateBANKALARAsync(BANKALAR model)
        {
            return await _BANKALARRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteBANKALARAsync(int ID)
        {
            return await _BANKALARRepository.DeleteAsync(ID);
        }

        public async Task<List<BANKALAR>> GetBANKALAR()
        {
            return await _BANKALARRepository.GetAllAsync();
        }

        public async Task<BANKALAR> GetBANKALARById(int ID)
        {
            return await _BANKALARRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateBANKALARAsync(BANKALAR model)
        {
            return await _BANKALARRepository.UpdateAsync(model);
        }
    }


}



