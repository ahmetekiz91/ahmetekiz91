

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MALZ_ROTA_URETILENServices : IMALZ_ROTA_URETILENServices
    {
        private readonly IMALZ_ROTA_URETILENRepository _MALZ_ROTA_URETILENRepository;

        public  MALZ_ROTA_URETILENServices(IMALZ_ROTA_URETILENRepository _MALZ_ROTA_URETILENRepository)
        {
            this._MALZ_ROTA_URETILENRepository = _MALZ_ROTA_URETILENRepository;
        }

        public async Task<bool> CreateMALZ_ROTA_URETILENAsync(MALZ_ROTA_URETILEN model)
        {
            return await _MALZ_ROTA_URETILENRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMALZ_ROTA_URETILENAsync(int ID)
        {
            return await _MALZ_ROTA_URETILENRepository.DeleteAsync(ID);
        }

        public async Task<List<MALZ_ROTA_URETILEN>> GetMALZ_ROTA_URETILEN()
        {
            return await _MALZ_ROTA_URETILENRepository.GetAllAsync();
        }

        public async Task<MALZ_ROTA_URETILEN> GetMALZ_ROTA_URETILENById(int ID)
        {
            return await _MALZ_ROTA_URETILENRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMALZ_ROTA_URETILENAsync(MALZ_ROTA_URETILEN model)
        {
            return await _MALZ_ROTA_URETILENRepository.UpdateAsync(model);
        }
    }


}



