

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class ATTRIBUTESServices : IATTRIBUTESServices
    {
        private readonly IATTRIBUTESRepository _ATTRIBUTESRepository;

        public  ATTRIBUTESServices(IATTRIBUTESRepository _ATTRIBUTESRepository)
        {
            this._ATTRIBUTESRepository = _ATTRIBUTESRepository;
        }

        public async Task<bool> CreateATTRIBUTESAsync(ATTRIBUTES model)
        {
            return await _ATTRIBUTESRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteATTRIBUTESAsync(int ID)
        {
            return await _ATTRIBUTESRepository.DeleteAsync(ID);
        }

        public async Task<List<ATTRIBUTES>> GetATTRIBUTES()
        {
            return await _ATTRIBUTESRepository.GetAllAsync();
        }

        public async Task<ATTRIBUTES> GetATTRIBUTESById(int ID)
        {
            return await _ATTRIBUTESRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateATTRIBUTESAsync(ATTRIBUTES model)
        {
            return await _ATTRIBUTESRepository.UpdateAsync(model);
        }
    }


}



