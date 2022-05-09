

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Talepler_ParamsServices : ITalepler_ParamsServices
    {
        private readonly ITalepler_ParamsRepository _Talepler_ParamsRepository;

        public  Talepler_ParamsServices(ITalepler_ParamsRepository _Talepler_ParamsRepository)
        {
            this._Talepler_ParamsRepository = _Talepler_ParamsRepository;
        }

        public async Task<bool> CreateTalepler_ParamsAsync(Talepler_Params model)
        {
            return await _Talepler_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTalepler_ParamsAsync(int ID)
        {
            return await _Talepler_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Talepler_Params>> GetTalepler_Params()
        {
            return await _Talepler_ParamsRepository.GetAllAsync();
        }

        public async Task<Talepler_Params> GetTalepler_ParamsById(int ID)
        {
            return await _Talepler_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTalepler_ParamsAsync(Talepler_Params model)
        {
            return await _Talepler_ParamsRepository.UpdateAsync(model);
        }
    }


}



