

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Teklif_Revizyon_KalemServices : ITeklif_Revizyon_KalemServices
    {
        private readonly ITeklif_Revizyon_KalemRepository _Teklif_Revizyon_KalemRepository;

        public  Teklif_Revizyon_KalemServices(ITeklif_Revizyon_KalemRepository _Teklif_Revizyon_KalemRepository)
        {
            this._Teklif_Revizyon_KalemRepository = _Teklif_Revizyon_KalemRepository;
        }

        public async Task<bool> CreateTeklif_Revizyon_KalemAsync(Teklif_Revizyon_Kalem model)
        {
            return await _Teklif_Revizyon_KalemRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTeklif_Revizyon_KalemAsync(int ID)
        {
            return await _Teklif_Revizyon_KalemRepository.DeleteAsync(ID);
        }

        public async Task<List<Teklif_Revizyon_Kalem>> GetTeklif_Revizyon_Kalem()
        {
            return await _Teklif_Revizyon_KalemRepository.GetAllAsync();
        }

        public async Task<Teklif_Revizyon_Kalem> GetTeklif_Revizyon_KalemById(int ID)
        {
            return await _Teklif_Revizyon_KalemRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTeklif_Revizyon_KalemAsync(Teklif_Revizyon_Kalem model)
        {
            return await _Teklif_Revizyon_KalemRepository.UpdateAsync(model);
        }
    }


}



