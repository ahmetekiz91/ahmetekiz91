

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Vardiya_Kisi_ParamsServices : IVardiya_Kisi_ParamsServices
    {
        private readonly IVardiya_Kisi_ParamsRepository _Vardiya_Kisi_ParamsRepository;

        public  Vardiya_Kisi_ParamsServices(IVardiya_Kisi_ParamsRepository _Vardiya_Kisi_ParamsRepository)
        {
            this._Vardiya_Kisi_ParamsRepository = _Vardiya_Kisi_ParamsRepository;
        }

        public async Task<bool> CreateVardiya_Kisi_ParamsAsync(Vardiya_Kisi_Params model)
        {
            return await _Vardiya_Kisi_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteVardiya_Kisi_ParamsAsync(int ID)
        {
            return await _Vardiya_Kisi_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Vardiya_Kisi_Params>> GetVardiya_Kisi_Params()
        {
            return await _Vardiya_Kisi_ParamsRepository.GetAllAsync();
        }

        public async Task<Vardiya_Kisi_Params> GetVardiya_Kisi_ParamsById(int ID)
        {
            return await _Vardiya_Kisi_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateVardiya_Kisi_ParamsAsync(Vardiya_Kisi_Params model)
        {
            return await _Vardiya_Kisi_ParamsRepository.UpdateAsync(model);
        }
    }


}



