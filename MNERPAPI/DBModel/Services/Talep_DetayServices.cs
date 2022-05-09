

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Talep_DetayServices : ITalep_DetayServices
    {
        private readonly ITalep_DetayRepository _Talep_DetayRepository;

        public  Talep_DetayServices(ITalep_DetayRepository _Talep_DetayRepository)
        {
            this._Talep_DetayRepository = _Talep_DetayRepository;
        }

        public async Task<bool> CreateTalep_DetayAsync(Talep_Detay model)
        {
            return await _Talep_DetayRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTalep_DetayAsync(int ID)
        {
            return await _Talep_DetayRepository.DeleteAsync(ID);
        }

        public async Task<List<Talep_Detay>> GetTalep_Detay()
        {
            return await _Talep_DetayRepository.GetAllAsync();
        }

        public async Task<Talep_Detay> GetTalep_DetayById(int ID)
        {
            return await _Talep_DetayRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTalep_DetayAsync(Talep_Detay model)
        {
            return await _Talep_DetayRepository.UpdateAsync(model);
        }
    }


}



