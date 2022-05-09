

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Teklif_RevizyonServices : ITeklif_RevizyonServices
    {
        private readonly ITeklif_RevizyonRepository _Teklif_RevizyonRepository;

        public  Teklif_RevizyonServices(ITeklif_RevizyonRepository _Teklif_RevizyonRepository)
        {
            this._Teklif_RevizyonRepository = _Teklif_RevizyonRepository;
        }

        public async Task<bool> CreateTeklif_RevizyonAsync(Teklif_Revizyon model)
        {
            return await _Teklif_RevizyonRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTeklif_RevizyonAsync(int ID)
        {
            return await _Teklif_RevizyonRepository.DeleteAsync(ID);
        }

        public async Task<List<Teklif_Revizyon>> GetTeklif_Revizyon()
        {
            return await _Teklif_RevizyonRepository.GetAllAsync();
        }

        public async Task<Teklif_Revizyon> GetTeklif_RevizyonById(int ID)
        {
            return await _Teklif_RevizyonRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTeklif_RevizyonAsync(Teklif_Revizyon model)
        {
            return await _Teklif_RevizyonRepository.UpdateAsync(model);
        }
    }


}



