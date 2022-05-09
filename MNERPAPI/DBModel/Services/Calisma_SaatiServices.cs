

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Calisma_SaatiServices : ICalisma_SaatiServices
    {
        private readonly ICalisma_SaatiRepository _Calisma_SaatiRepository;

        public  Calisma_SaatiServices(ICalisma_SaatiRepository _Calisma_SaatiRepository)
        {
            this._Calisma_SaatiRepository = _Calisma_SaatiRepository;
        }

        public async Task<bool> CreateCalisma_SaatiAsync(Calisma_Saati model)
        {
            return await _Calisma_SaatiRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteCalisma_SaatiAsync(int ID)
        {
            return await _Calisma_SaatiRepository.DeleteAsync(ID);
        }

        public async Task<List<Calisma_Saati>> GetCalisma_Saati()
        {
            return await _Calisma_SaatiRepository.GetAllAsync();
        }

        public async Task<Calisma_Saati> GetCalisma_SaatiById(int ID)
        {
            return await _Calisma_SaatiRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateCalisma_SaatiAsync(Calisma_Saati model)
        {
            return await _Calisma_SaatiRepository.UpdateAsync(model);
        }
    }


}



