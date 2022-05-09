

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Kasa_HareketServices : IKasa_HareketServices
    {
        private readonly IKasa_HareketRepository _Kasa_HareketRepository;

        public  Kasa_HareketServices(IKasa_HareketRepository _Kasa_HareketRepository)
        {
            this._Kasa_HareketRepository = _Kasa_HareketRepository;
        }

        public async Task<bool> CreateKasa_HareketAsync(Kasa_Hareket model)
        {
            return await _Kasa_HareketRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteKasa_HareketAsync(int ID)
        {
            return await _Kasa_HareketRepository.DeleteAsync(ID);
        }

        public async Task<List<Kasa_Hareket>> GetKasa_Hareket()
        {
            return await _Kasa_HareketRepository.GetAllAsync();
        }

        public async Task<Kasa_Hareket> GetKasa_HareketById(int ID)
        {
            return await _Kasa_HareketRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateKasa_HareketAsync(Kasa_Hareket model)
        {
            return await _Kasa_HareketRepository.UpdateAsync(model);
        }
    }


}



