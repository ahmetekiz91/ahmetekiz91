

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Kul_RollerServices : IKul_RollerServices
    {
        private readonly IKul_RollerRepository _Kul_RollerRepository;

        public  Kul_RollerServices(IKul_RollerRepository _Kul_RollerRepository)
        {
            this._Kul_RollerRepository = _Kul_RollerRepository;
        }

        public async Task<bool> CreateKul_RollerAsync(Kul_Roller model)
        {
            return await _Kul_RollerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteKul_RollerAsync(int ID)
        {
            return await _Kul_RollerRepository.DeleteAsync(ID);
        }

        public async Task<List<Kul_Roller>> GetKul_Roller()
        {
            return await _Kul_RollerRepository.GetAllAsync();
        }

        public async Task<Kul_Roller> GetKul_RollerById(int ID)
        {
            return await _Kul_RollerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateKul_RollerAsync(Kul_Roller model)
        {
            return await _Kul_RollerRepository.UpdateAsync(model);
        }
    }


}



