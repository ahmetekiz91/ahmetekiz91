

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Rota_TanımlarıServices : IRota_TanımlarıServices
    {
        private readonly IRota_TanımlarıRepository _Rota_TanımlarıRepository;

        public  Rota_TanımlarıServices(IRota_TanımlarıRepository _Rota_TanımlarıRepository)
        {
            this._Rota_TanımlarıRepository = _Rota_TanımlarıRepository;
        }

        public async Task<bool> CreateRota_TanımlarıAsync(Rota_Tanımları model)
        {
            return await _Rota_TanımlarıRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteRota_TanımlarıAsync(int ID)
        {
            return await _Rota_TanımlarıRepository.DeleteAsync(ID);
        }

        public async Task<List<Rota_Tanımları>> GetRota_Tanımları()
        {
            return await _Rota_TanımlarıRepository.GetAllAsync();
        }

        public async Task<Rota_Tanımları> GetRota_TanımlarıById(int ID)
        {
            return await _Rota_TanımlarıRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateRota_TanımlarıAsync(Rota_Tanımları model)
        {
            return await _Rota_TanımlarıRepository.UpdateAsync(model);
        }
    }


}



