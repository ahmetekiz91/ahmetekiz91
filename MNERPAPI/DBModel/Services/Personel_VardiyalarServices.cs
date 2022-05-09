

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Personel_VardiyalarServices : IPersonel_VardiyalarServices
    {
        private readonly IPersonel_VardiyalarRepository _Personel_VardiyalarRepository;

        public  Personel_VardiyalarServices(IPersonel_VardiyalarRepository _Personel_VardiyalarRepository)
        {
            this._Personel_VardiyalarRepository = _Personel_VardiyalarRepository;
        }

        public async Task<bool> CreatePersonel_VardiyalarAsync(Personel_Vardiyalar model)
        {
            return await _Personel_VardiyalarRepository.CreateAsync(model);
        }

        public async Task<bool> DeletePersonel_VardiyalarAsync(int ID)
        {
            return await _Personel_VardiyalarRepository.DeleteAsync(ID);
        }

        public async Task<List<Personel_Vardiyalar>> GetPersonel_Vardiyalar()
        {
            return await _Personel_VardiyalarRepository.GetAllAsync();
        }

        public async Task<Personel_Vardiyalar> GetPersonel_VardiyalarById(int ID)
        {
            return await _Personel_VardiyalarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdatePersonel_VardiyalarAsync(Personel_Vardiyalar model)
        {
            return await _Personel_VardiyalarRepository.UpdateAsync(model);
        }
    }


}



