

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Gorev_Not_ParamsServices : IGorev_Not_ParamsServices
    {
        private readonly IGorev_Not_ParamsRepository _Gorev_Not_ParamsRepository;

        public  Gorev_Not_ParamsServices(IGorev_Not_ParamsRepository _Gorev_Not_ParamsRepository)
        {
            this._Gorev_Not_ParamsRepository = _Gorev_Not_ParamsRepository;
        }

        public async Task<bool> CreateGorev_Not_ParamsAsync(Gorev_Not_Params model)
        {
            return await _Gorev_Not_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteGorev_Not_ParamsAsync(int ID)
        {
            return await _Gorev_Not_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Gorev_Not_Params>> GetGorev_Not_Params()
        {
            return await _Gorev_Not_ParamsRepository.GetAllAsync();
        }

        public async Task<Gorev_Not_Params> GetGorev_Not_ParamsById(int ID)
        {
            return await _Gorev_Not_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateGorev_Not_ParamsAsync(Gorev_Not_Params model)
        {
            return await _Gorev_Not_ParamsRepository.UpdateAsync(model);
        }
    }


}



