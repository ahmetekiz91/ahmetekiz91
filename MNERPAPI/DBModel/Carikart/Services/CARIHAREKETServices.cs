

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class CARIHAREKETServices : ICARIHAREKETServices
    {
        private readonly ICARIHAREKETRepository _CARIHAREKETRepository;

        public  CARIHAREKETServices(ICARIHAREKETRepository _CARIHAREKETRepository)
        {
            this._CARIHAREKETRepository = _CARIHAREKETRepository;
        }

        public async Task<bool> CreateCARIHAREKETAsync(CARIHAREKET model)
        {
            return await _CARIHAREKETRepository.CreateAsync(model);
        }
     
        public async Task<bool> DeleteCARIHAREKETAsync(int ID)
        {
            return await _CARIHAREKETRepository.DeleteAsync(ID);
        }

        public async Task<List<CARIHAREKET>> GetCARIHAREKET()
        {
            return await _CARIHAREKETRepository.GetAllAsync();
        }

        public async Task<CARIHAREKET> GetCARIHAREKETById(int ID)
        {
            return await _CARIHAREKETRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateCARIHAREKETAsync(CARIHAREKET model)
        {
            return await _CARIHAREKETRepository.UpdateAsync(model);
        }
    }


}



