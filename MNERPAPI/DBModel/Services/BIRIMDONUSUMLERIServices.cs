

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class BIRIMDONUSUMLERIServices : IBIRIMDONUSUMLERIServices
    {
        private readonly IBIRIMDONUSUMLERIRepository _BIRIMDONUSUMLERIRepository;

        public  BIRIMDONUSUMLERIServices(IBIRIMDONUSUMLERIRepository _BIRIMDONUSUMLERIRepository)
        {
            this._BIRIMDONUSUMLERIRepository = _BIRIMDONUSUMLERIRepository;
        }

        public async Task<bool> CreateBIRIMDONUSUMLERIAsync(BIRIMDONUSUMLERI model)
        {
            return await _BIRIMDONUSUMLERIRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteBIRIMDONUSUMLERIAsync(int ID)
        {
            return await _BIRIMDONUSUMLERIRepository.DeleteAsync(ID);
        }

        public async Task<List<BIRIMDONUSUMLERI>> GetBIRIMDONUSUMLERI()
        {
            return await _BIRIMDONUSUMLERIRepository.GetAllAsync();
        }

        public async Task<BIRIMDONUSUMLERI> GetBIRIMDONUSUMLERIById(int ID)
        {
            return await _BIRIMDONUSUMLERIRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateBIRIMDONUSUMLERIAsync(BIRIMDONUSUMLERI model)
        {
            return await _BIRIMDONUSUMLERIRepository.UpdateAsync(model);
        }
    }


}



