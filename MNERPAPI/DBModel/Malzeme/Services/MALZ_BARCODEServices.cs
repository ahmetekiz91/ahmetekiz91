

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MALZ_BARCODEServices : IMALZ_BARCODEServices
    {
        private readonly IMALZ_BARCODERepository _MALZ_BARCODERepository;

        public  MALZ_BARCODEServices(IMALZ_BARCODERepository _MALZ_BARCODERepository)
        {
            this._MALZ_BARCODERepository = _MALZ_BARCODERepository;
        }

        public async Task<bool> CreateMALZ_BARCODEAsync(MALZ_BARCODE model)
        {
            return await _MALZ_BARCODERepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMALZ_BARCODEAsync(int ID)
        {
            return await _MALZ_BARCODERepository.DeleteAsync(ID);
        }

        public async Task<List<MALZ_BARCODE>> GetMALZ_BARCODE()
        {
            return await _MALZ_BARCODERepository.GetAllAsync();
        }

        public async Task<MALZ_BARCODE> GetMALZ_BARCODEById(int ID)
        {
            return await _MALZ_BARCODERepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMALZ_BARCODEAsync(MALZ_BARCODE model)
        {
            return await _MALZ_BARCODERepository.UpdateAsync(model);
        }
    }


}



