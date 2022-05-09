

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Sevk_DetayServices : ISevk_DetayServices
    {
        private readonly ISevk_DetayRepository _Sevk_DetayRepository;

        public  Sevk_DetayServices(ISevk_DetayRepository _Sevk_DetayRepository)
        {
            this._Sevk_DetayRepository = _Sevk_DetayRepository;
        }

        public async Task<bool> CreateSevk_DetayAsync(Sevk_Detay model)
        {
            return await _Sevk_DetayRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteSevk_DetayAsync(int ID)
        {
            return await _Sevk_DetayRepository.DeleteAsync(ID);
        }

        public async Task<List<Sevk_Detay>> GetSevk_Detay()
        {
            return await _Sevk_DetayRepository.GetAllAsync();
        }

        public async Task<Sevk_Detay> GetSevk_DetayById(int ID)
        {
            return await _Sevk_DetayRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateSevk_DetayAsync(Sevk_Detay model)
        {
            return await _Sevk_DetayRepository.UpdateAsync(model);
        }
    }


}



