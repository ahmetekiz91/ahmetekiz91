

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Rota_Tanimlari_ParamsServices : IRota_Tanimlari_ParamsServices
    {
        private readonly IRota_Tanimlari_ParamsRepository _Rota_Tanimlari_ParamsRepository;

        public  Rota_Tanimlari_ParamsServices(IRota_Tanimlari_ParamsRepository _Rota_Tanimlari_ParamsRepository)
        {
            this._Rota_Tanimlari_ParamsRepository = _Rota_Tanimlari_ParamsRepository;
        }

        public async Task<bool> CreateRota_Tanimlari_ParamsAsync(Rota_Tanimlari_Params model)
        {
            return await _Rota_Tanimlari_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteRota_Tanimlari_ParamsAsync(int ID)
        {
            return await _Rota_Tanimlari_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Rota_Tanimlari_Params>> GetRota_Tanimlari_Params()
        {
            return await _Rota_Tanimlari_ParamsRepository.GetAllAsync();
        }

        public async Task<Rota_Tanimlari_Params> GetRota_Tanimlari_ParamsById(int ID)
        {
            return await _Rota_Tanimlari_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateRota_Tanimlari_ParamsAsync(Rota_Tanimlari_Params model)
        {
            return await _Rota_Tanimlari_ParamsRepository.UpdateAsync(model);
        }
    }


}



