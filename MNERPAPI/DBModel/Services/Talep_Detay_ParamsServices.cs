

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Talep_Detay_ParamsServices : ITalep_Detay_ParamsServices
    {
        private readonly ITalep_Detay_ParamsRepository _Talep_Detay_ParamsRepository;

        public  Talep_Detay_ParamsServices(ITalep_Detay_ParamsRepository _Talep_Detay_ParamsRepository)
        {
            this._Talep_Detay_ParamsRepository = _Talep_Detay_ParamsRepository;
        }

        public async Task<bool> CreateTalep_Detay_ParamsAsync(Talep_Detay_Params model)
        {
            return await _Talep_Detay_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTalep_Detay_ParamsAsync(int ID)
        {
            return await _Talep_Detay_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Talep_Detay_Params>> GetTalep_Detay_Params()
        {
            return await _Talep_Detay_ParamsRepository.GetAllAsync();
        }

        public async Task<Talep_Detay_Params> GetTalep_Detay_ParamsById(int ID)
        {
            return await _Talep_Detay_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTalep_Detay_ParamsAsync(Talep_Detay_Params model)
        {
            return await _Talep_Detay_ParamsRepository.UpdateAsync(model);
        }
    }


}



