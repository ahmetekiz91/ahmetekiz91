

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class SiparislerServices : ISiparislerServices
    {
        private readonly ISiparislerRepository _SiparislerRepository;

        public  SiparislerServices(ISiparislerRepository _SiparislerRepository)
        {
            this._SiparislerRepository = _SiparislerRepository;
        }

        public async Task<bool> CreateSiparislerAsync(Siparisler model)
        {
            return await _SiparislerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteSiparislerAsync(int ID)
        {
            return await _SiparislerRepository.DeleteAsync(ID);
        }

        public async Task<List<Siparisler>> GetSiparisler()
        {
            return await _SiparislerRepository.GetAllAsync();
        }

        public async Task<Siparisler> GetSiparislerById(int ID)
        {
            return await _SiparislerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateSiparislerAsync(Siparisler model)
        {
            return await _SiparislerRepository.UpdateAsync(model);
        }
    }


}



