

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Vardiyalar_ParamsServices : IVardiyalar_ParamsServices
    {
        private readonly IVardiyalar_ParamsRepository _Vardiyalar_ParamsRepository;

        public  Vardiyalar_ParamsServices(IVardiyalar_ParamsRepository _Vardiyalar_ParamsRepository)
        {
            this._Vardiyalar_ParamsRepository = _Vardiyalar_ParamsRepository;
        }

        public async Task<bool> CreateVardiyalar_ParamsAsync(Vardiyalar_Params model)
        {
            return await _Vardiyalar_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteVardiyalar_ParamsAsync(int ID)
        {
            return await _Vardiyalar_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Vardiyalar_Params>> GetVardiyalar_Params()
        {
            return await _Vardiyalar_ParamsRepository.GetAllAsync();
        }

        public async Task<Vardiyalar_Params> GetVardiyalar_ParamsById(int ID)
        {
            return await _Vardiyalar_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateVardiyalar_ParamsAsync(Vardiyalar_Params model)
        {
            return await _Vardiyalar_ParamsRepository.UpdateAsync(model);
        }
    }


}



