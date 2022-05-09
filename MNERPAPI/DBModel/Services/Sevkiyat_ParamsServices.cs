

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Sevkiyat_ParamsServices : ISevkiyat_ParamsServices
    {
        private readonly ISevkiyat_ParamsRepository _Sevkiyat_ParamsRepository;

        public  Sevkiyat_ParamsServices(ISevkiyat_ParamsRepository _Sevkiyat_ParamsRepository)
        {
            this._Sevkiyat_ParamsRepository = _Sevkiyat_ParamsRepository;
        }

        public async Task<bool> CreateSevkiyat_ParamsAsync(Sevkiyat_Params model)
        {
            return await _Sevkiyat_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteSevkiyat_ParamsAsync(int ID)
        {
            return await _Sevkiyat_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Sevkiyat_Params>> GetSevkiyat_Params()
        {
            return await _Sevkiyat_ParamsRepository.GetAllAsync();
        }

        public async Task<Sevkiyat_Params> GetSevkiyat_ParamsById(int ID)
        {
            return await _Sevkiyat_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateSevkiyat_ParamsAsync(Sevkiyat_Params model)
        {
            return await _Sevkiyat_ParamsRepository.UpdateAsync(model);
        }
    }


}



