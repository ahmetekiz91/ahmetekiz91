

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class BANKAHAREKETServices : IBANKAHAREKETServices
    {
        private readonly IBANKAHAREKETRepository _BANKAHAREKETRepository;

        public  BANKAHAREKETServices(IBANKAHAREKETRepository _BANKAHAREKETRepository)
        {
            this._BANKAHAREKETRepository = _BANKAHAREKETRepository;
        }

        public async Task<bool> CreateBANKAHAREKETAsync(BANKAHAREKET model)
        {
            return await _BANKAHAREKETRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteBANKAHAREKETAsync(int ID)
        {
            return await _BANKAHAREKETRepository.DeleteAsync(ID);
        }

        public async Task<List<BANKAHAREKET>> GetBANKAHAREKET()
        {
            return await _BANKAHAREKETRepository.GetAllAsync();
        }

        public async Task<BANKAHAREKET> GetBANKAHAREKETById(int ID)
        {
            return await _BANKAHAREKETRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateBANKAHAREKETAsync(BANKAHAREKET model)
        {
            return await _BANKAHAREKETRepository.UpdateAsync(model);
        }
    }


}



