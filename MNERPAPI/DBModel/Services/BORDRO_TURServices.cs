

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class BORDRO_TURServices : IBORDRO_TURServices
    {
        private readonly IBORDRO_TURRepository _BORDRO_TURRepository;

        public  BORDRO_TURServices(IBORDRO_TURRepository _BORDRO_TURRepository)
        {
            this._BORDRO_TURRepository = _BORDRO_TURRepository;
        }

        public async Task<bool> CreateBORDRO_TURAsync(BORDRO_TUR model)
        {
            return await _BORDRO_TURRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteBORDRO_TURAsync(int ID)
        {
            return await _BORDRO_TURRepository.DeleteAsync(ID);
        }

        public async Task<List<BORDRO_TUR>> GetBORDRO_TUR()
        {
            return await _BORDRO_TURRepository.GetAllAsync();
        }

        public async Task<BORDRO_TUR> GetBORDRO_TURById(int ID)
        {
            return await _BORDRO_TURRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateBORDRO_TURAsync(BORDRO_TUR model)
        {
            return await _BORDRO_TURRepository.UpdateAsync(model);
        }
    }


}



