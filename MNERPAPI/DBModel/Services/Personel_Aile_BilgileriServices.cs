

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Personel_Aile_BilgileriServices : IPersonel_Aile_BilgileriServices
    {
        private readonly IPersonel_Aile_BilgileriRepository _Personel_Aile_BilgileriRepository;

        public  Personel_Aile_BilgileriServices(IPersonel_Aile_BilgileriRepository _Personel_Aile_BilgileriRepository)
        {
            this._Personel_Aile_BilgileriRepository = _Personel_Aile_BilgileriRepository;
        }

        public async Task<bool> CreatePersonel_Aile_BilgileriAsync(Personel_Aile_Bilgileri model)
        {
            return await _Personel_Aile_BilgileriRepository.CreateAsync(model);
        }

        public async Task<bool> DeletePersonel_Aile_BilgileriAsync(int ID)
        {
            return await _Personel_Aile_BilgileriRepository.DeleteAsync(ID);
        }

        public async Task<List<Personel_Aile_Bilgileri>> GetPersonel_Aile_Bilgileri()
        {
            return await _Personel_Aile_BilgileriRepository.GetAllAsync();
        }

        public async Task<Personel_Aile_Bilgileri> GetPersonel_Aile_BilgileriById(int ID)
        {
            return await _Personel_Aile_BilgileriRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdatePersonel_Aile_BilgileriAsync(Personel_Aile_Bilgileri model)
        {
            return await _Personel_Aile_BilgileriRepository.UpdateAsync(model);
        }
    }


}



