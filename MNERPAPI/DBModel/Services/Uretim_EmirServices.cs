

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Uretim_EmirServices : IUretim_EmirServices
    {
        private readonly IUretim_EmirRepository _Uretim_EmirRepository;

        public  Uretim_EmirServices(IUretim_EmirRepository _Uretim_EmirRepository)
        {
            this._Uretim_EmirRepository = _Uretim_EmirRepository;
        }

        public async Task<bool> CreateUretim_EmirAsync(Uretim_Emir model)
        {
            return await _Uretim_EmirRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteUretim_EmirAsync(int ID)
        {
            return await _Uretim_EmirRepository.DeleteAsync(ID);
        }

        public async Task<List<Uretim_Emir>> GetUretim_Emir()
        {
            return await _Uretim_EmirRepository.GetAllAsync();
        }

        public async Task<Uretim_Emir> GetUretim_EmirById(int ID)
        {
            return await _Uretim_EmirRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateUretim_EmirAsync(Uretim_Emir model)
        {
            return await _Uretim_EmirRepository.UpdateAsync(model);
        }
    }


}



