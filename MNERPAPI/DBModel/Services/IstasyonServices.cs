

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class IstasyonServices : IIstasyonServices
    {
        private readonly IIstasyonRepository _IstasyonRepository;

        public  IstasyonServices(IIstasyonRepository _IstasyonRepository)
        {
            this._IstasyonRepository = _IstasyonRepository;
        }

        public async Task<bool> CreateIstasyonAsync(Istasyon model)
        {
            return await _IstasyonRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteIstasyonAsync(int ID)
        {
            return await _IstasyonRepository.DeleteAsync(ID);
        }

        public async Task<List<Istasyon>> GetIstasyon()
        {
            return await _IstasyonRepository.GetAllAsync();
        }

        public async Task<Istasyon> GetIstasyonById(int ID)
        {
            return await _IstasyonRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateIstasyonAsync(Istasyon model)
        {
            return await _IstasyonRepository.UpdateAsync(model);
        }
    }


}



