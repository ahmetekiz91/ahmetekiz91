

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Sevk_PlaniServices : ISevk_PlaniServices
    {
        private readonly ISevk_PlaniRepository _Sevk_PlaniRepository;

        public  Sevk_PlaniServices(ISevk_PlaniRepository _Sevk_PlaniRepository)
        {
            this._Sevk_PlaniRepository = _Sevk_PlaniRepository;
        }

        public async Task<bool> CreateSevk_PlaniAsync(Sevk_Plani model)
        {
            return await _Sevk_PlaniRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteSevk_PlaniAsync(int ID)
        {
            return await _Sevk_PlaniRepository.DeleteAsync(ID);
        }

        public async Task<List<Sevk_Plani>> GetSevk_Plani()
        {
            return await _Sevk_PlaniRepository.GetAllAsync();
        }

        public async Task<Sevk_Plani> GetSevk_PlaniById(int ID)
        {
            return await _Sevk_PlaniRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateSevk_PlaniAsync(Sevk_Plani model)
        {
            return await _Sevk_PlaniRepository.UpdateAsync(model);
        }
    }


}



