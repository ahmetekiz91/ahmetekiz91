

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class BANKAISLEMTURLERIServices : IBANKAISLEMTURLERIServices
    {

        private readonly IBANKAISLEMTURLERIRepository _BANKAISLEMTURLERIRepository;

        public  BANKAISLEMTURLERIServices(IBANKAISLEMTURLERIRepository _BANKAISLEMTURLERIRepository)
        {
            this._BANKAISLEMTURLERIRepository = _BANKAISLEMTURLERIRepository;
        }

        public async Task<bool> CreateBANKAISLEMTURLERIAsync(BANKAISLEMTURLERI model)
        {
            return await _BANKAISLEMTURLERIRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteBANKAISLEMTURLERIAsync(int ID)
        {
            return await _BANKAISLEMTURLERIRepository.DeleteAsync(ID);
        }

        public async Task<List<BANKAISLEMTURLERI>> GetBANKAISLEMTURLERI()
        {
            return await _BANKAISLEMTURLERIRepository.GetAllAsync();
        }

        public async Task<BANKAISLEMTURLERI> GetBANKAISLEMTURLERIById(int ID)
        {
            return await _BANKAISLEMTURLERIRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateBANKAISLEMTURLERIAsync(BANKAISLEMTURLERI model)
        {
            return await _BANKAISLEMTURLERIRepository.UpdateAsync(model);
        }
    }


}



