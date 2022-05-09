

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Mak_MalzServices : IMak_MalzServices
    {
        private readonly IMak_MalzRepository _Mak_MalzRepository;

        public  Mak_MalzServices(IMak_MalzRepository _Mak_MalzRepository)
        {
            this._Mak_MalzRepository = _Mak_MalzRepository;
        }

        public async Task<bool> CreateMak_MalzAsync(Mak_Malz model)
        {
            return await _Mak_MalzRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMak_MalzAsync(int ID)
        {
            return await _Mak_MalzRepository.DeleteAsync(ID);
        }

        public async Task<List<Mak_Malz>> GetMak_Malz()
        {
            return await _Mak_MalzRepository.GetAllAsync();
        }

        public async Task<Mak_Malz> GetMak_MalzById(int ID)
        {
            return await _Mak_MalzRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMak_MalzAsync(Mak_Malz model)
        {
            return await _Mak_MalzRepository.UpdateAsync(model);
        }
    }


}



