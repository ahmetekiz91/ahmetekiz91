

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Uretim_Planlama_UretimServices : IUretim_Planlama_UretimServices
    {
        private readonly IUretim_Planlama_UretimRepository _Uretim_Planlama_UretimRepository;

        public  Uretim_Planlama_UretimServices(IUretim_Planlama_UretimRepository _Uretim_Planlama_UretimRepository)
        {
            this._Uretim_Planlama_UretimRepository = _Uretim_Planlama_UretimRepository;
        }

        public async Task<bool> CreateUretim_Planlama_UretimAsync(Uretim_Planlama_Uretim model)
        {
            return await _Uretim_Planlama_UretimRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteUretim_Planlama_UretimAsync(int ID)
        {
            return await _Uretim_Planlama_UretimRepository.DeleteAsync(ID);
        }

        public async Task<List<Uretim_Planlama_Uretim>> GetUretim_Planlama_Uretim()
        {
            return await _Uretim_Planlama_UretimRepository.GetAllAsync();
        }

        public async Task<Uretim_Planlama_Uretim> GetUretim_Planlama_UretimById(int ID)
        {
            return await _Uretim_Planlama_UretimRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateUretim_Planlama_UretimAsync(Uretim_Planlama_Uretim model)
        {
            return await _Uretim_Planlama_UretimRepository.UpdateAsync(model);
        }
    }


}



