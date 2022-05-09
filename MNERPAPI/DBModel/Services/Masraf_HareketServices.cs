

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Masraf_HareketServices : IMasraf_HareketServices
    {
        private readonly IMasraf_HareketRepository _Masraf_HareketRepository;

        public  Masraf_HareketServices(IMasraf_HareketRepository _Masraf_HareketRepository)
        {
            this._Masraf_HareketRepository = _Masraf_HareketRepository;
        }

        public async Task<bool> CreateMasraf_HareketAsync(Masraf_Hareket model)
        {
            return await _Masraf_HareketRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMasraf_HareketAsync(int ID)
        {
            return await _Masraf_HareketRepository.DeleteAsync(ID);
        }

        public async Task<List<Masraf_Hareket>> GetMasraf_Hareket()
        {
            return await _Masraf_HareketRepository.GetAllAsync();
        }

        public async Task<Masraf_Hareket> GetMasraf_HareketById(int ID)
        {
            return await _Masraf_HareketRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMasraf_HareketAsync(Masraf_Hareket model)
        {
            return await _Masraf_HareketRepository.UpdateAsync(model);
        }
    }


}



