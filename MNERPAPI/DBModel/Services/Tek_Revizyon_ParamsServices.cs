

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Tek_Revizyon_ParamsServices : ITek_Revizyon_ParamsServices
    {
        private readonly ITek_Revizyon_ParamsRepository _Tek_Revizyon_ParamsRepository;

        public  Tek_Revizyon_ParamsServices(ITek_Revizyon_ParamsRepository _Tek_Revizyon_ParamsRepository)
        {
            this._Tek_Revizyon_ParamsRepository = _Tek_Revizyon_ParamsRepository;
        }

        public async Task<bool> CreateTek_Revizyon_ParamsAsync(Tek_Revizyon_Params model)
        {
            return await _Tek_Revizyon_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTek_Revizyon_ParamsAsync(int ID)
        {
            return await _Tek_Revizyon_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Tek_Revizyon_Params>> GetTek_Revizyon_Params()
        {
            return await _Tek_Revizyon_ParamsRepository.GetAllAsync();
        }

        public async Task<Tek_Revizyon_Params> GetTek_Revizyon_ParamsById(int ID)
        {
            return await _Tek_Revizyon_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTek_Revizyon_ParamsAsync(Tek_Revizyon_Params model)
        {
            return await _Tek_Revizyon_ParamsRepository.UpdateAsync(model);
        }
    }


}



