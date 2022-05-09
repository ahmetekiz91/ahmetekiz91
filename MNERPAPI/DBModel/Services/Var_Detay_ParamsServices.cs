

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Var_Detay_ParamsServices : IVar_Detay_ParamsServices
    {
        private readonly IVar_Detay_ParamsRepository _Var_Detay_ParamsRepository;

        public  Var_Detay_ParamsServices(IVar_Detay_ParamsRepository _Var_Detay_ParamsRepository)
        {
            this._Var_Detay_ParamsRepository = _Var_Detay_ParamsRepository;
        }

        public async Task<bool> CreateVar_Detay_ParamsAsync(Var_Detay_Params model)
        {
            return await _Var_Detay_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteVar_Detay_ParamsAsync(int ID)
        {
            return await _Var_Detay_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Var_Detay_Params>> GetVar_Detay_Params()
        {
            return await _Var_Detay_ParamsRepository.GetAllAsync();
        }

        public async Task<Var_Detay_Params> GetVar_Detay_ParamsById(int ID)
        {
            return await _Var_Detay_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateVar_Detay_ParamsAsync(Var_Detay_Params model)
        {
            return await _Var_Detay_ParamsRepository.UpdateAsync(model);
        }
    }


}



