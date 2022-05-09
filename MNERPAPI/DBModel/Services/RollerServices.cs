

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class RollerServices : IRollerServices
    {
        private readonly IRollerRepository _RollerRepository;

        public  RollerServices(IRollerRepository _RollerRepository)
        {
            this._RollerRepository = _RollerRepository;
        }

        public async Task<bool> CreateRollerAsync(Roller model)
        {
            return await _RollerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteRollerAsync(int ID)
        {
            return await _RollerRepository.DeleteAsync(ID);
        }

        public async Task<List<Roller>> GetRoller()
        {
            return await _RollerRepository.GetAllAsync();
        }

        public async Task<Roller> GetRollerById(int ID)
        {
            return await _RollerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateRollerAsync(Roller model)
        {
            return await _RollerRepository.UpdateAsync(model);
        }
    }


}



