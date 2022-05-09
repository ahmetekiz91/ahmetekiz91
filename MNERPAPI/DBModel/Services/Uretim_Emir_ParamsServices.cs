

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Uretim_Emir_ParamsServices : IUretim_Emir_ParamsServices
    {
        private readonly IUretim_Emir_ParamsRepository _Uretim_Emir_ParamsRepository;

        public  Uretim_Emir_ParamsServices(IUretim_Emir_ParamsRepository _Uretim_Emir_ParamsRepository)
        {
            this._Uretim_Emir_ParamsRepository = _Uretim_Emir_ParamsRepository;
        }

        public async Task<bool> CreateUretim_Emir_ParamsAsync(Uretim_Emir_Params model)
        {
            return await _Uretim_Emir_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteUretim_Emir_ParamsAsync(int ID)
        {
            return await _Uretim_Emir_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Uretim_Emir_Params>> GetUretim_Emir_Params()
        {
            return await _Uretim_Emir_ParamsRepository.GetAllAsync();
        }

        public async Task<Uretim_Emir_Params> GetUretim_Emir_ParamsById(int ID)
        {
            return await _Uretim_Emir_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateUretim_Emir_ParamsAsync(Uretim_Emir_Params model)
        {
            return await _Uretim_Emir_ParamsRepository.UpdateAsync(model);
        }
    }


}



