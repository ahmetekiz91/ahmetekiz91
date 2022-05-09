

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class BIRIMLERServices : IBIRIMLERServices
    {
        private readonly IBIRIMLERRepository _BIRIMLERRepository;

        public  BIRIMLERServices(IBIRIMLERRepository _BIRIMLERRepository)
        {
            this._BIRIMLERRepository = _BIRIMLERRepository;
        }

        public async Task<bool> CreateBIRIMLERAsync(BIRIMLER model)
        {
            return await _BIRIMLERRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteBIRIMLERAsync(int ID)
        {
            return await _BIRIMLERRepository.DeleteAsync(ID);
        }

        public async Task<List<BIRIMLER>> GetBIRIMLER()
        {
            return await _BIRIMLERRepository.GetAllAsync();
        }

        public async Task<BIRIMLER> GetBIRIMLERById(int ID)
        {
            return await _BIRIMLERRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateBIRIMLERAsync(BIRIMLER model)
        {
            return await _BIRIMLERRepository.UpdateAsync(model);
        }
    }


}



