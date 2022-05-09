

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Malz_HareketServices : IMalz_HareketServices
    {
        private readonly IMalz_HareketRepository _Malz_HareketRepository;

        public  Malz_HareketServices(IMalz_HareketRepository _Malz_HareketRepository)
        {
            this._Malz_HareketRepository = _Malz_HareketRepository;
        }

        public async Task<bool> CreateMalz_HareketAsync(Malz_Hareket model)
        {
            return await _Malz_HareketRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMalz_HareketAsync(int ID)
        {
            return await _Malz_HareketRepository.DeleteAsync(ID);
        }

        public async Task<List<Malz_Hareket>> GetMalz_Hareket()
        {
            return await _Malz_HareketRepository.GetAllAsync();
        }

        public async Task<Malz_Hareket> GetMalz_HareketById(int ID)
        {
            return await _Malz_HareketRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMalz_HareketAsync(Malz_Hareket model)
        {
            return await _Malz_HareketRepository.UpdateAsync(model);
        }
    }


}



