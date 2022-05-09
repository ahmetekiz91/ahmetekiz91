

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Gorev_TalepServices : IGorev_TalepServices
    {
        private readonly IGorev_TalepRepository _Gorev_TalepRepository;

        public  Gorev_TalepServices(IGorev_TalepRepository _Gorev_TalepRepository)
        {
            this._Gorev_TalepRepository = _Gorev_TalepRepository;
        }

        public async Task<bool> CreateGorev_TalepAsync(Gorev_Talep model)
        {
            return await _Gorev_TalepRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteGorev_TalepAsync(int ID)
        {
            return await _Gorev_TalepRepository.DeleteAsync(ID);
        }

        public async Task<List<Gorev_Talep>> GetGorev_Talep()
        {
            return await _Gorev_TalepRepository.GetAllAsync();
        }

        public async Task<Gorev_Talep> GetGorev_TalepById(int ID)
        {
            return await _Gorev_TalepRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateGorev_TalepAsync(Gorev_Talep model)
        {
            return await _Gorev_TalepRepository.UpdateAsync(model);
        }
    }


}



