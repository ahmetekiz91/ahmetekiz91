

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Teklif_Sevk_Plani_ParamsServices : ITeklif_Sevk_Plani_ParamsServices
    {
        private readonly ITeklif_Sevk_Plani_ParamsRepository _Teklif_Sevk_Plani_ParamsRepository;

        public  Teklif_Sevk_Plani_ParamsServices(ITeklif_Sevk_Plani_ParamsRepository _Teklif_Sevk_Plani_ParamsRepository)
        {
            this._Teklif_Sevk_Plani_ParamsRepository = _Teklif_Sevk_Plani_ParamsRepository;
        }

        public async Task<bool> CreateTeklif_Sevk_Plani_ParamsAsync(Teklif_Sevk_Plani_Params model)
        {
            return await _Teklif_Sevk_Plani_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTeklif_Sevk_Plani_ParamsAsync(int ID)
        {
            return await _Teklif_Sevk_Plani_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Teklif_Sevk_Plani_Params>> GetTeklif_Sevk_Plani_Params()
        {
            return await _Teklif_Sevk_Plani_ParamsRepository.GetAllAsync();
        }

        public async Task<Teklif_Sevk_Plani_Params> GetTeklif_Sevk_Plani_ParamsById(int ID)
        {
            return await _Teklif_Sevk_Plani_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTeklif_Sevk_Plani_ParamsAsync(Teklif_Sevk_Plani_Params model)
        {
            return await _Teklif_Sevk_Plani_ParamsRepository.UpdateAsync(model);
        }
    }


}



