

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Teklif_Sevk_PlaniServices : ITeklif_Sevk_PlaniServices
    {
        private readonly ITeklif_Sevk_PlaniRepository _Teklif_Sevk_PlaniRepository;

        public  Teklif_Sevk_PlaniServices(ITeklif_Sevk_PlaniRepository _Teklif_Sevk_PlaniRepository)
        {
            this._Teklif_Sevk_PlaniRepository = _Teklif_Sevk_PlaniRepository;
        }

        public async Task<bool> CreateTeklif_Sevk_PlaniAsync(Teklif_Sevk_Plani model)
        {
            return await _Teklif_Sevk_PlaniRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTeklif_Sevk_PlaniAsync(int ID)
        {
            return await _Teklif_Sevk_PlaniRepository.DeleteAsync(ID);
        }

        public async Task<List<Teklif_Sevk_Plani>> GetTeklif_Sevk_Plani()
        {
            return await _Teklif_Sevk_PlaniRepository.GetAllAsync();
        }

        public async Task<Teklif_Sevk_Plani> GetTeklif_Sevk_PlaniById(int ID)
        {
            return await _Teklif_Sevk_PlaniRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTeklif_Sevk_PlaniAsync(Teklif_Sevk_Plani model)
        {
            return await _Teklif_Sevk_PlaniRepository.UpdateAsync(model);
        }
    }


}



