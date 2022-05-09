

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class PersonellerServices : IPersonellerServices
    {
        private readonly IPersonellerRepository _PersonellerRepository;

        public  PersonellerServices(IPersonellerRepository _PersonellerRepository)
        {
            this._PersonellerRepository = _PersonellerRepository;
        }

        public async Task<bool> CreatePersonellerAsync(Personeller model)
        {
            return await _PersonellerRepository.CreateAsync(model);
        }

        public async Task<bool> DeletePersonellerAsync(int ID)
        {
            return await _PersonellerRepository.DeleteAsync(ID);
        }

        public async Task<List<Personeller>> GetPersoneller()
        {
            return await _PersonellerRepository.GetAllAsync();
        }

        public async Task<Personeller> GetPersonellerById(int ID)
        {
            return await _PersonellerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdatePersonellerAsync(Personeller model)
        {
            return await _PersonellerRepository.UpdateAsync(model);
        }
    }


}



