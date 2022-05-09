

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Duy_DetayServices : IDuy_DetayServices
    {
        private readonly IDuy_DetayRepository _Duy_DetayRepository;

        public  Duy_DetayServices(IDuy_DetayRepository _Duy_DetayRepository)
        {
            this._Duy_DetayRepository = _Duy_DetayRepository;
        }

        public async Task<bool> CreateDuy_DetayAsync(Duy_Detay model)
        {
            return await _Duy_DetayRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteDuy_DetayAsync(int ID)
        {
            return await _Duy_DetayRepository.DeleteAsync(ID);
        }

        public async Task<List<Duy_Detay>> GetDuy_Detay()
        {
            return await _Duy_DetayRepository.GetAllAsync();
        }

        public async Task<Duy_Detay> GetDuy_DetayById(int ID)
        {
            return await _Duy_DetayRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateDuy_DetayAsync(Duy_Detay model)
        {
            return await _Duy_DetayRepository.UpdateAsync(model);
        }
    }


}



