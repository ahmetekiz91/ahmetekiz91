

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Malz_Hareket_ParamsServices : IMalz_Hareket_ParamsServices
    {
        private readonly IMalz_Hareket_ParamsRepository _Malz_Hareket_ParamsRepository;

        public  Malz_Hareket_ParamsServices(IMalz_Hareket_ParamsRepository _Malz_Hareket_ParamsRepository)
        {
            this._Malz_Hareket_ParamsRepository = _Malz_Hareket_ParamsRepository;
        }

        public async Task<bool> CreateMalz_Hareket_ParamsAsync(Malz_Hareket_Params model)
        {
            return await _Malz_Hareket_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMalz_Hareket_ParamsAsync(int ID)
        {
            return await _Malz_Hareket_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Malz_Hareket_Params>> GetMalz_Hareket_Params()
        {
            return await _Malz_Hareket_ParamsRepository.GetAllAsync();
        }

        public async Task<Malz_Hareket_Params> GetMalz_Hareket_ParamsById(int ID)
        {
            return await _Malz_Hareket_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMalz_Hareket_ParamsAsync(Malz_Hareket_Params model)
        {
            return await _Malz_Hareket_ParamsRepository.UpdateAsync(model);
        }
    }


}



