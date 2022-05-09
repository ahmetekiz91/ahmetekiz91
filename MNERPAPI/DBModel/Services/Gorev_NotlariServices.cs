

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Gorev_NotlariServices : IGorev_NotlariServices
    {
        private readonly IGorev_NotlariRepository _Gorev_NotlariRepository;

        public  Gorev_NotlariServices(IGorev_NotlariRepository _Gorev_NotlariRepository)
        {
            this._Gorev_NotlariRepository = _Gorev_NotlariRepository;
        }

        public async Task<bool> CreateGorev_NotlariAsync(Gorev_Notlari model)
        {
            return await _Gorev_NotlariRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteGorev_NotlariAsync(int ID)
        {
            return await _Gorev_NotlariRepository.DeleteAsync(ID);
        }

        public async Task<List<Gorev_Notlari>> GetGorev_Notlari()
        {
            return await _Gorev_NotlariRepository.GetAllAsync();
        }

        public async Task<Gorev_Notlari> GetGorev_NotlariById(int ID)
        {
            return await _Gorev_NotlariRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateGorev_NotlariAsync(Gorev_Notlari model)
        {
            return await _Gorev_NotlariRepository.UpdateAsync(model);
        }
    }


}



