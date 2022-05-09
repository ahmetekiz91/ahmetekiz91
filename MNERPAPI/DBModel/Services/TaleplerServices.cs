

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class TaleplerServices : ITaleplerServices
    {
        private readonly ITaleplerRepository _TaleplerRepository;

        public  TaleplerServices(ITaleplerRepository _TaleplerRepository)
        {
            this._TaleplerRepository = _TaleplerRepository;
        }

        public async Task<bool> CreateTaleplerAsync(Talepler model)
        {
            return await _TaleplerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTaleplerAsync(int ID)
        {
            return await _TaleplerRepository.DeleteAsync(ID);
        }

        public async Task<List<Talepler>> GetTalepler()
        {
            return await _TaleplerRepository.GetAllAsync();
        }

        public async Task<Talepler> GetTaleplerById(int ID)
        {
            return await _TaleplerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTaleplerAsync(Talepler model)
        {
            return await _TaleplerRepository.UpdateAsync(model);
        }
    }


}



