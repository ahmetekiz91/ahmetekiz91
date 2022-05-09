

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Malz_KategorileriServices : IMalz_KategorileriServices
    {
        private readonly IMalz_KategorileriRepository _Malz_KategorileriRepository;

        public  Malz_KategorileriServices(IMalz_KategorileriRepository _Malz_KategorileriRepository)
        {
            this._Malz_KategorileriRepository = _Malz_KategorileriRepository;
        }

        public async Task<bool> CreateMalz_KategorileriAsync(Malz_Kategorileri model)
        {
            return await _Malz_KategorileriRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMalz_KategorileriAsync(int ID)
        {
            return await _Malz_KategorileriRepository.DeleteAsync(ID);
        }

        public async Task<List<Malz_Kategorileri>> GetMalz_Kategorileri()
        {
            return await _Malz_KategorileriRepository.GetAllAsync();
        }

        public async Task<Malz_Kategorileri> GetMalz_KategorileriById(int ID)
        {
            return await _Malz_KategorileriRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMalz_KategorileriAsync(Malz_Kategorileri model)
        {
            return await _Malz_KategorileriRepository.UpdateAsync(model);
        }
    }


}



