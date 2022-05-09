

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Fiili_Uretim_TuketimServices : IFiili_Uretim_TuketimServices
    {
        private readonly IFiili_Uretim_TuketimRepository _Fiili_Uretim_TuketimRepository;

        public  Fiili_Uretim_TuketimServices(IFiili_Uretim_TuketimRepository _Fiili_Uretim_TuketimRepository)
        {
            this._Fiili_Uretim_TuketimRepository = _Fiili_Uretim_TuketimRepository;
        }

        public async Task<bool> CreateFiili_Uretim_TuketimAsync(Fiili_Uretim_Tuketim model)
        {
            return await _Fiili_Uretim_TuketimRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteFiili_Uretim_TuketimAsync(int ID)
        {
            return await _Fiili_Uretim_TuketimRepository.DeleteAsync(ID);
        }

        public async Task<List<Fiili_Uretim_Tuketim>> GetFiili_Uretim_Tuketim()
        {
            return await _Fiili_Uretim_TuketimRepository.GetAllAsync();
        }

        public async Task<Fiili_Uretim_Tuketim> GetFiili_Uretim_TuketimById(int ID)
        {
            return await _Fiili_Uretim_TuketimRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateFiili_Uretim_TuketimAsync(Fiili_Uretim_Tuketim model)
        {
            return await _Fiili_Uretim_TuketimRepository.UpdateAsync(model);
        }
    }


}



