

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Personel_ParamsServices : IPersonel_ParamsServices
    {
        private readonly IPersonel_ParamsRepository _Personel_ParamsRepository;

        public  Personel_ParamsServices(IPersonel_ParamsRepository _Personel_ParamsRepository)
        {
            this._Personel_ParamsRepository = _Personel_ParamsRepository;
        }

        public async Task<bool> CreatePersonel_ParamsAsync(Personel_Params model)
        {
            return await _Personel_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeletePersonel_ParamsAsync(int ID)
        {
            return await _Personel_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Personel_Params>> GetPersonel_Params()
        {
            return await _Personel_ParamsRepository.GetAllAsync();
        }

        public async Task<Personel_Params> GetPersonel_ParamsById(int ID)
        {
            return await _Personel_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdatePersonel_ParamsAsync(Personel_Params model)
        {
            return await _Personel_ParamsRepository.UpdateAsync(model);
        }
    }


}



