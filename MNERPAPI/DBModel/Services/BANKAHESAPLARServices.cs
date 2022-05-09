

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class BANKAHESAPLARServices : IBANKAHESAPLARServices
    {
        private readonly IBANKAHESAPLARRepository _BANKAHESAPLARRepository;

        public  BANKAHESAPLARServices(IBANKAHESAPLARRepository _BANKAHESAPLARRepository)
        {
            this._BANKAHESAPLARRepository = _BANKAHESAPLARRepository;
        }

        public async Task<bool> CreateBANKAHESAPLARAsync(BANKAHESAPLAR model)
        {
            return await _BANKAHESAPLARRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteBANKAHESAPLARAsync(int ID)
        {
            return await _BANKAHESAPLARRepository.DeleteAsync(ID);
        }

        public async Task<List<BANKAHESAPLAR>> GetBANKAHESAPLAR()
        {
            return await _BANKAHESAPLARRepository.GetAllAsync();
        }

        public async Task<BANKAHESAPLAR> GetBANKAHESAPLARById(int ID)
        {
            return await _BANKAHESAPLARRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateBANKAHESAPLARAsync(BANKAHESAPLAR model)
        {
            return await _BANKAHESAPLARRepository.UpdateAsync(model);
        }
    }


}



