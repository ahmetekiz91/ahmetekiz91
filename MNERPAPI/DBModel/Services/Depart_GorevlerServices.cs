

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Depart_GorevlerServices : IDepart_GorevlerServices
    {
        private readonly IDepart_GorevlerRepository _Depart_GorevlerRepository;

        public  Depart_GorevlerServices(IDepart_GorevlerRepository _Depart_GorevlerRepository)
        {
            this._Depart_GorevlerRepository = _Depart_GorevlerRepository;
        }

        public async Task<bool> CreateDepart_GorevlerAsync(Depart_Gorevler model)
        {
            return await _Depart_GorevlerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteDepart_GorevlerAsync(int ID)
        {
            return await _Depart_GorevlerRepository.DeleteAsync(ID);
        }

        public async Task<List<Depart_Gorevler>> GetDepart_Gorevler()
        {
            return await _Depart_GorevlerRepository.GetAllAsync();
        }

        public async Task<Depart_Gorevler> GetDepart_GorevlerById(int ID)
        {
            return await _Depart_GorevlerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateDepart_GorevlerAsync(Depart_Gorevler model)
        {
            return await _Depart_GorevlerRepository.UpdateAsync(model);
        }
    }


}



