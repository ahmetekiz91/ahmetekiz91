

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class DovizTurleriServices : IDovizTurleriServices
    {
        private readonly IDovizTurleriRepository _DovizTurleriRepository;

        public  DovizTurleriServices(IDovizTurleriRepository _DovizTurleriRepository)
        {
            this._DovizTurleriRepository = _DovizTurleriRepository;
        }

        public async Task<bool> CreateDovizTurleriAsync(DovizTurleri model)
        {
            return await _DovizTurleriRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteDovizTurleriAsync(int ID)
        {
            return await _DovizTurleriRepository.DeleteAsync(ID);
        }

        public async Task<List<DovizTurleri>> GetDovizTurleri()
        {
            return await _DovizTurleriRepository.GetAllAsync();
        }

        public async Task<DovizTurleri> GetDovizTurleriById(int ID)
        {
            return await _DovizTurleriRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateDovizTurleriAsync(DovizTurleri model)
        {
            return await _DovizTurleriRepository.UpdateAsync(model);
        }
    }


}



