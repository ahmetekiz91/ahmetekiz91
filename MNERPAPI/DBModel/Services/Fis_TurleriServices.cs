

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Fis_TurleriServices : IFis_TurleriServices
    {
        private readonly IFis_TurleriRepository _Fis_TurleriRepository;

        public  Fis_TurleriServices(IFis_TurleriRepository _Fis_TurleriRepository)
        {
            this._Fis_TurleriRepository = _Fis_TurleriRepository;
        }

        public async Task<bool> CreateFis_TurleriAsync(Fis_Turleri model)
        {
            return await _Fis_TurleriRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteFis_TurleriAsync(int ID)
        {
            return await _Fis_TurleriRepository.DeleteAsync(ID);
        }

        public async Task<List<Fis_Turleri>> GetFis_Turleri()
        {
            return await _Fis_TurleriRepository.GetAllAsync();
        }

        public async Task<Fis_Turleri> GetFis_TurleriById(int ID)
        {
            return await _Fis_TurleriRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateFis_TurleriAsync(Fis_Turleri model)
        {
            return await _Fis_TurleriRepository.UpdateAsync(model);
        }
    }


}



