

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Mal_Alis_ParamServices : IMal_Alis_ParamServices
    {
        private readonly IMal_Alis_ParamRepository _Mal_Alis_ParamRepository;

        public  Mal_Alis_ParamServices(IMal_Alis_ParamRepository _Mal_Alis_ParamRepository)
        {
            this._Mal_Alis_ParamRepository = _Mal_Alis_ParamRepository;
        }

        public async Task<bool> CreateMal_Alis_ParamAsync(Mal_Alis_Param model)
        {
            return await _Mal_Alis_ParamRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMal_Alis_ParamAsync(int ID)
        {
            return await _Mal_Alis_ParamRepository.DeleteAsync(ID);
        }

        public async Task<List<Mal_Alis_Param>> GetMal_Alis_Param()
        {
            return await _Mal_Alis_ParamRepository.GetAllAsync();
        }

        public async Task<Mal_Alis_Param> GetMal_Alis_ParamById(int ID)
        {
            return await _Mal_Alis_ParamRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMal_Alis_ParamAsync(Mal_Alis_Param model)
        {
            return await _Mal_Alis_ParamRepository.UpdateAsync(model);
        }
    }


}



