

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Vardiya_KisilerServices : IVardiya_KisilerServices
    {
        private readonly IVardiya_KisilerRepository _Vardiya_KisilerRepository;

        public  Vardiya_KisilerServices(IVardiya_KisilerRepository _Vardiya_KisilerRepository)
        {
            this._Vardiya_KisilerRepository = _Vardiya_KisilerRepository;
        }

        public async Task<bool> CreateVardiya_KisilerAsync(Vardiya_Kisiler model)
        {
            return await _Vardiya_KisilerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteVardiya_KisilerAsync(int ID)
        {
            return await _Vardiya_KisilerRepository.DeleteAsync(ID);
        }

        public async Task<List<Vardiya_Kisiler>> GetVardiya_Kisiler()
        {
            return await _Vardiya_KisilerRepository.GetAllAsync();
        }

        public async Task<Vardiya_Kisiler> GetVardiya_KisilerById(int ID)
        {
            return await _Vardiya_KisilerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateVardiya_KisilerAsync(Vardiya_Kisiler model)
        {
            return await _Vardiya_KisilerRepository.UpdateAsync(model);
        }
    }


}



