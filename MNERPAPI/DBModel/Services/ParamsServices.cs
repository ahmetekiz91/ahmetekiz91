

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class ParamsServices : IParamsServices
    {
        private readonly IParamsRepository _ParamsRepository;

        public  ParamsServices(IParamsRepository _ParamsRepository)
        {
            this._ParamsRepository = _ParamsRepository;
        }

        public async Task<bool> CreateParamsAsync(Params model)
        {
            return await _ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteParamsAsync(int ID)
        {
            return await _ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Params>> GetParams()
        {
            return await _ParamsRepository.GetAllAsync();
        }

        public async Task<Params> GetParamsById(int ID)
        {
            return await _ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateParamsAsync(Params model)
        {
            return await _ParamsRepository.UpdateAsync(model);
        }
    }


}



