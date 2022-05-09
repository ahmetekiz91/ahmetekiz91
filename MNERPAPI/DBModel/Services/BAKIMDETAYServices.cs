

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class BAKIMDETAYServices : IBAKIMDETAYServices
    {
        private readonly IBAKIMDETAYRepository _BAKIMDETAYRepository;

        public  BAKIMDETAYServices(IBAKIMDETAYRepository _BAKIMDETAYRepository)
        {
            this._BAKIMDETAYRepository = _BAKIMDETAYRepository;
        }

        public async Task<bool> CreateBAKIMDETAYAsync(BAKIMDETAY model)
        {
            return await _BAKIMDETAYRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteBAKIMDETAYAsync(int ID)
        {
            return await _BAKIMDETAYRepository.DeleteAsync(ID);
        }

        public async Task<List<BAKIMDETAY>> GetBAKIMDETAY()
        {
            return await _BAKIMDETAYRepository.GetAllAsync();
        }

        public async Task<BAKIMDETAY> GetBAKIMDETAYById(int ID)
        {
            return await _BAKIMDETAYRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateBAKIMDETAYAsync(BAKIMDETAY model)
        {
            return await _BAKIMDETAYRepository.UpdateAsync(model);
        }
    }


}



