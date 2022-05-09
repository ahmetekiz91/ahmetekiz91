

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Sevk_Detay_ParamsServices : ISevk_Detay_ParamsServices
    {
        private readonly ISevk_Detay_ParamsRepository _Sevk_Detay_ParamsRepository;

        public  Sevk_Detay_ParamsServices(ISevk_Detay_ParamsRepository _Sevk_Detay_ParamsRepository)
        {
            this._Sevk_Detay_ParamsRepository = _Sevk_Detay_ParamsRepository;
        }

        public async Task<bool> CreateSevk_Detay_ParamsAsync(Sevk_Detay_Params model)
        {
            return await _Sevk_Detay_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteSevk_Detay_ParamsAsync(int ID)
        {
            return await _Sevk_Detay_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Sevk_Detay_Params>> GetSevk_Detay_Params()
        {
            return await _Sevk_Detay_ParamsRepository.GetAllAsync();
        }

        public async Task<Sevk_Detay_Params> GetSevk_Detay_ParamsById(int ID)
        {
            return await _Sevk_Detay_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateSevk_Detay_ParamsAsync(Sevk_Detay_Params model)
        {
            return await _Sevk_Detay_ParamsRepository.UpdateAsync(model);
        }
    }


}



