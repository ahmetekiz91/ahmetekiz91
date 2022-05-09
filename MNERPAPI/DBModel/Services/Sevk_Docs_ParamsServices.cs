

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Sevk_Docs_ParamsServices : ISevk_Docs_ParamsServices
    {
        private readonly ISevk_Docs_ParamsRepository _Sevk_Docs_ParamsRepository;

        public  Sevk_Docs_ParamsServices(ISevk_Docs_ParamsRepository _Sevk_Docs_ParamsRepository)
        {
            this._Sevk_Docs_ParamsRepository = _Sevk_Docs_ParamsRepository;
        }

        public async Task<bool> CreateSevk_Docs_ParamsAsync(Sevk_Docs_Params model)
        {
            return await _Sevk_Docs_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteSevk_Docs_ParamsAsync(int ID)
        {
            return await _Sevk_Docs_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Sevk_Docs_Params>> GetSevk_Docs_Params()
        {
            return await _Sevk_Docs_ParamsRepository.GetAllAsync();
        }

        public async Task<Sevk_Docs_Params> GetSevk_Docs_ParamsById(int ID)
        {
            return await _Sevk_Docs_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateSevk_Docs_ParamsAsync(Sevk_Docs_Params model)
        {
            return await _Sevk_Docs_ParamsRepository.UpdateAsync(model);
        }
    }


}



