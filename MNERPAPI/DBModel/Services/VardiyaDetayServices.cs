

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class VardiyaDetayServices : IVardiyaDetayServices
    {
        private readonly IVardiyaDetayRepository _VardiyaDetayRepository;

        public  VardiyaDetayServices(IVardiyaDetayRepository _VardiyaDetayRepository)
        {
            this._VardiyaDetayRepository = _VardiyaDetayRepository;
        }

        public async Task<bool> CreateVardiyaDetayAsync(VardiyaDetay model)
        {
            return await _VardiyaDetayRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteVardiyaDetayAsync(int ID)
        {
            return await _VardiyaDetayRepository.DeleteAsync(ID);
        }

        public async Task<List<VardiyaDetay>> GetVardiyaDetay()
        {
            return await _VardiyaDetayRepository.GetAllAsync();
        }

        public async Task<VardiyaDetay> GetVardiyaDetayById(int ID)
        {
            return await _VardiyaDetayRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateVardiyaDetayAsync(VardiyaDetay model)
        {
            return await _VardiyaDetayRepository.UpdateAsync(model);
        }
    }


}



