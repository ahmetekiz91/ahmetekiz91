

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Kredi_KartlariServices : IKredi_KartlariServices
    {
        private readonly IKredi_KartlariRepository _Kredi_KartlariRepository;

        public  Kredi_KartlariServices(IKredi_KartlariRepository _Kredi_KartlariRepository)
        {
            this._Kredi_KartlariRepository = _Kredi_KartlariRepository;
        }

        public async Task<bool> CreateKredi_KartlariAsync(Kredi_Kartlari model)
        {
            return await _Kredi_KartlariRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteKredi_KartlariAsync(int ID)
        {
            return await _Kredi_KartlariRepository.DeleteAsync(ID);
        }

        public async Task<List<Kredi_Kartlari>> GetKredi_Kartlari()
        {
            return await _Kredi_KartlariRepository.GetAllAsync();
        }

        public async Task<Kredi_Kartlari> GetKredi_KartlariById(int ID)
        {
            return await _Kredi_KartlariRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateKredi_KartlariAsync(Kredi_Kartlari model)
        {
            return await _Kredi_KartlariRepository.UpdateAsync(model);
        }
    }


}



