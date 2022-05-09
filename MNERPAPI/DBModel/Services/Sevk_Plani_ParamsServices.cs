

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Sevk_Plani_ParamsServices : ISevk_Plani_ParamsServices
    {
        private readonly ISevk_Plani_ParamsRepository _Sevk_Plani_ParamsRepository;

        public  Sevk_Plani_ParamsServices(ISevk_Plani_ParamsRepository _Sevk_Plani_ParamsRepository)
        {
            this._Sevk_Plani_ParamsRepository = _Sevk_Plani_ParamsRepository;
        }

        public async Task<bool> CreateSevk_Plani_ParamsAsync(Sevk_Plani_Params model)
        {
            return await _Sevk_Plani_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteSevk_Plani_ParamsAsync(int ID)
        {
            return await _Sevk_Plani_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Sevk_Plani_Params>> GetSevk_Plani_Params()
        {
            return await _Sevk_Plani_ParamsRepository.GetAllAsync();
        }

        public async Task<Sevk_Plani_Params> GetSevk_Plani_ParamsById(int ID)
        {
            return await _Sevk_Plani_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateSevk_Plani_ParamsAsync(Sevk_Plani_Params model)
        {
            return await _Sevk_Plani_ParamsRepository.UpdateAsync(model);
        }
    }


}



