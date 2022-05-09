

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Teklif_Revizyon_Kalem_ParamsServices : ITeklif_Revizyon_Kalem_ParamsServices
    {
        private readonly ITeklif_Revizyon_Kalem_ParamsRepository _Teklif_Revizyon_Kalem_ParamsRepository;

        public  Teklif_Revizyon_Kalem_ParamsServices(ITeklif_Revizyon_Kalem_ParamsRepository _Teklif_Revizyon_Kalem_ParamsRepository)
        {
            this._Teklif_Revizyon_Kalem_ParamsRepository = _Teklif_Revizyon_Kalem_ParamsRepository;
        }

        public async Task<bool> CreateTeklif_Revizyon_Kalem_ParamsAsync(Teklif_Revizyon_Kalem_Params model)
        {
            return await _Teklif_Revizyon_Kalem_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTeklif_Revizyon_Kalem_ParamsAsync(int ID)
        {
            return await _Teklif_Revizyon_Kalem_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Teklif_Revizyon_Kalem_Params>> GetTeklif_Revizyon_Kalem_Params()
        {
            return await _Teklif_Revizyon_Kalem_ParamsRepository.GetAllAsync();
        }

        public async Task<Teklif_Revizyon_Kalem_Params> GetTeklif_Revizyon_Kalem_ParamsById(int ID)
        {
            return await _Teklif_Revizyon_Kalem_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTeklif_Revizyon_Kalem_ParamsAsync(Teklif_Revizyon_Kalem_Params model)
        {
            return await _Teklif_Revizyon_Kalem_ParamsRepository.UpdateAsync(model);
        }
    }


}



