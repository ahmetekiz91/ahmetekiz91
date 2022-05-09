

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Fiili_UretimServices : IFiili_UretimServices
    {
        private readonly IFiili_UretimRepository _Fiili_UretimRepository;

        public  Fiili_UretimServices(IFiili_UretimRepository _Fiili_UretimRepository)
        {
            this._Fiili_UretimRepository = _Fiili_UretimRepository;
        }

        public async Task<bool> CreateFiili_UretimAsync(Fiili_Uretim model)
        {
            return await _Fiili_UretimRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteFiili_UretimAsync(int ID)
        {
            return await _Fiili_UretimRepository.DeleteAsync(ID);
        }

        public async Task<List<Fiili_Uretim>> GetFiili_Uretim()
        {
            return await _Fiili_UretimRepository.GetAllAsync();
        }

        public async Task<Fiili_Uretim> GetFiili_UretimById(int ID)
        {
            return await _Fiili_UretimRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateFiili_UretimAsync(Fiili_Uretim model)
        {
            return await _Fiili_UretimRepository.UpdateAsync(model);
        }
    }


}



