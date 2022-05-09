

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Siparisler_ParamsServices : ISiparisler_ParamsServices
    {
        private readonly ISiparisler_ParamsRepository _Siparisler_ParamsRepository;

        public  Siparisler_ParamsServices(ISiparisler_ParamsRepository _Siparisler_ParamsRepository)
        {
            this._Siparisler_ParamsRepository = _Siparisler_ParamsRepository;
        }

        public async Task<bool> CreateSiparisler_ParamsAsync(Siparisler_Params model)
        {
            return await _Siparisler_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteSiparisler_ParamsAsync(int ID)
        {
            return await _Siparisler_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Siparisler_Params>> GetSiparisler_Params()
        {
            return await _Siparisler_ParamsRepository.GetAllAsync();
        }

        public async Task<Siparisler_Params> GetSiparisler_ParamsById(int ID)
        {
            return await _Siparisler_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateSiparisler_ParamsAsync(Siparisler_Params model)
        {
            return await _Siparisler_ParamsRepository.UpdateAsync(model);
        }
    }


}



