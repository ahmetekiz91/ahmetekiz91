

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Teslimat_TuruServices : ITeslimat_TuruServices
    {
        private readonly ITeslimat_TuruRepository _Teslimat_TuruRepository;

        public  Teslimat_TuruServices(ITeslimat_TuruRepository _Teslimat_TuruRepository)
        {
            this._Teslimat_TuruRepository = _Teslimat_TuruRepository;
        }

        public async Task<bool> CreateTeslimat_TuruAsync(Teslimat_Turu model)
        {
            return await _Teslimat_TuruRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTeslimat_TuruAsync(int ID)
        {
            return await _Teslimat_TuruRepository.DeleteAsync(ID);
        }

        public async Task<List<Teslimat_Turu>> GetTeslimat_Turu()
        {
            return await _Teslimat_TuruRepository.GetAllAsync();
        }

        public async Task<Teslimat_Turu> GetTeslimat_TuruById(int ID)
        {
            return await _Teslimat_TuruRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTeslimat_TuruAsync(Teslimat_Turu model)
        {
            return await _Teslimat_TuruRepository.UpdateAsync(model);
        }
    }


}



