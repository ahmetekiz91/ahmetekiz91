

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Muhasebe_HesaplariServices : IMuhasebe_HesaplariServices
    {
        private readonly IMuhasebe_HesaplariRepository _Muhasebe_HesaplariRepository;

        public  Muhasebe_HesaplariServices(IMuhasebe_HesaplariRepository _Muhasebe_HesaplariRepository)
        {
            this._Muhasebe_HesaplariRepository = _Muhasebe_HesaplariRepository;
        }

        public async Task<bool> CreateMuhasebe_HesaplariAsync(Muhasebe_Hesaplari model)
        {
            return await _Muhasebe_HesaplariRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMuhasebe_HesaplariAsync(int ID)
        {
            return await _Muhasebe_HesaplariRepository.DeleteAsync(ID);
        }

        public async Task<List<Muhasebe_Hesaplari>> GetMuhasebe_Hesaplari()
        {
            return await _Muhasebe_HesaplariRepository.GetAllAsync();
        }

        public async Task<Muhasebe_Hesaplari> GetMuhasebe_HesaplariById(int ID)
        {
            return await _Muhasebe_HesaplariRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMuhasebe_HesaplariAsync(Muhasebe_Hesaplari model)
        {
            return await _Muhasebe_HesaplariRepository.UpdateAsync(model);
        }
    }


}



