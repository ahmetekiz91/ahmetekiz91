

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class BORDROHAREKETServices : IBORDROHAREKETServices
    {
        private readonly IBORDROHAREKETRepository _BORDROHAREKETRepository;

        public  BORDROHAREKETServices(IBORDROHAREKETRepository _BORDROHAREKETRepository)
        {
            this._BORDROHAREKETRepository = _BORDROHAREKETRepository;
        }

        public async Task<bool> CreateBORDROHAREKETAsync(BORDROHAREKET model)
        {
            return await _BORDROHAREKETRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteBORDROHAREKETAsync(int ID)
        {
            return await _BORDROHAREKETRepository.DeleteAsync(ID);
        }

        public async Task<List<BORDROHAREKET>> GetBORDROHAREKET()
        {
            return await _BORDROHAREKETRepository.GetAllAsync();
        }

        public async Task<BORDROHAREKET> GetBORDROHAREKETById(int ID)
        {
            return await _BORDROHAREKETRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateBORDROHAREKETAsync(BORDROHAREKET model)
        {
            return await _BORDROHAREKETRepository.UpdateAsync(model);
        }
    }


}



