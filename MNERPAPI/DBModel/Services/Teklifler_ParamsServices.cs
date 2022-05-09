

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Teklifler_ParamsServices : ITeklifler_ParamsServices
    {
        private readonly ITeklifler_ParamsRepository _Teklifler_ParamsRepository;

        public  Teklifler_ParamsServices(ITeklifler_ParamsRepository _Teklifler_ParamsRepository)
        {
            this._Teklifler_ParamsRepository = _Teklifler_ParamsRepository;
        }

        public async Task<bool> CreateTeklifler_ParamsAsync(Teklifler_Params model)
        {
            return await _Teklifler_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTeklifler_ParamsAsync(int ID)
        {
            return await _Teklifler_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Teklifler_Params>> GetTeklifler_Params()
        {
            return await _Teklifler_ParamsRepository.GetAllAsync();
        }

        public async Task<Teklifler_Params> GetTeklifler_ParamsById(int ID)
        {
            return await _Teklifler_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTeklifler_ParamsAsync(Teklifler_Params model)
        {
            return await _Teklifler_ParamsRepository.UpdateAsync(model);
        }
    }


}



