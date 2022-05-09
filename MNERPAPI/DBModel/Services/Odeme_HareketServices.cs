

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Odeme_HareketServices : IOdeme_HareketServices
    {
        private readonly IOdeme_HareketRepository _Odeme_HareketRepository;

        public  Odeme_HareketServices(IOdeme_HareketRepository _Odeme_HareketRepository)
        {
            this._Odeme_HareketRepository = _Odeme_HareketRepository;
        }

        public async Task<bool> CreateOdeme_HareketAsync(Odeme_Hareket model)
        {
            return await _Odeme_HareketRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteOdeme_HareketAsync(int ID)
        {
            return await _Odeme_HareketRepository.DeleteAsync(ID);
        }

        public async Task<List<Odeme_Hareket>> GetOdeme_Hareket()
        {
            return await _Odeme_HareketRepository.GetAllAsync();
        }

        public async Task<Odeme_Hareket> GetOdeme_HareketById(int ID)
        {
            return await _Odeme_HareketRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateOdeme_HareketAsync(Odeme_Hareket model)
        {
            return await _Odeme_HareketRepository.UpdateAsync(model);
        }
    }


}



