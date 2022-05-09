

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Uretim_Planlama_TuketimServices : IUretim_Planlama_TuketimServices
    {
        private readonly IUretim_Planlama_TuketimRepository _Uretim_Planlama_TuketimRepository;

        public  Uretim_Planlama_TuketimServices(IUretim_Planlama_TuketimRepository _Uretim_Planlama_TuketimRepository)
        {
            this._Uretim_Planlama_TuketimRepository = _Uretim_Planlama_TuketimRepository;
        }

        public async Task<bool> CreateUretim_Planlama_TuketimAsync(Uretim_Planlama_Tuketim model)
        {
            return await _Uretim_Planlama_TuketimRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteUretim_Planlama_TuketimAsync(int ID)
        {
            return await _Uretim_Planlama_TuketimRepository.DeleteAsync(ID);
        }

        public async Task<List<Uretim_Planlama_Tuketim>> GetUretim_Planlama_Tuketim()
        {
            return await _Uretim_Planlama_TuketimRepository.GetAllAsync();
        }

        public async Task<Uretim_Planlama_Tuketim> GetUretim_Planlama_TuketimById(int ID)
        {
            return await _Uretim_Planlama_TuketimRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateUretim_Planlama_TuketimAsync(Uretim_Planlama_Tuketim model)
        {
            return await _Uretim_Planlama_TuketimRepository.UpdateAsync(model);
        }
    }


}



