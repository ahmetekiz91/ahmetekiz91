

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Gorevler_ParamsServices : IGorevler_ParamsServices
    {
        private readonly IGorevler_ParamsRepository _Gorevler_ParamsRepository;

        public  Gorevler_ParamsServices(IGorevler_ParamsRepository _Gorevler_ParamsRepository)
        {
            this._Gorevler_ParamsRepository = _Gorevler_ParamsRepository;
        }

        public async Task<bool> CreateGorevler_ParamsAsync(Gorevler_Params model)
        {
            return await _Gorevler_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteGorevler_ParamsAsync(int ID)
        {
            return await _Gorevler_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Gorevler_Params>> GetGorevler_Params()
        {
            return await _Gorevler_ParamsRepository.GetAllAsync();
        }

        public async Task<Gorevler_Params> GetGorevler_ParamsById(int ID)
        {
            return await _Gorevler_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateGorevler_ParamsAsync(Gorevler_Params model)
        {
            return await _Gorevler_ParamsRepository.UpdateAsync(model);
        }
    }


}



