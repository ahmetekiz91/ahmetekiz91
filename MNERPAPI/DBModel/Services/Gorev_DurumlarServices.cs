

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Gorev_DurumlarServices : IGorev_DurumlarServices
    {
        private readonly IGorev_DurumlarRepository _Gorev_DurumlarRepository;

        public  Gorev_DurumlarServices(IGorev_DurumlarRepository _Gorev_DurumlarRepository)
        {
            this._Gorev_DurumlarRepository = _Gorev_DurumlarRepository;
        }

        public async Task<bool> CreateGorev_DurumlarAsync(Gorev_Durumlar model)
        {
            return await _Gorev_DurumlarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteGorev_DurumlarAsync(int ID)
        {
            return await _Gorev_DurumlarRepository.DeleteAsync(ID);
        }

        public async Task<List<Gorev_Durumlar>> GetGorev_Durumlar()
        {
            return await _Gorev_DurumlarRepository.GetAllAsync();
        }

        public async Task<Gorev_Durumlar> GetGorev_DurumlarById(int ID)
        {
            return await _Gorev_DurumlarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateGorev_DurumlarAsync(Gorev_Durumlar model)
        {
            return await _Gorev_DurumlarRepository.UpdateAsync(model);
        }
    }


}



