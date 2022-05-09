

using DBModel.Model;
using DBModel.Utility;
using FINANS.Infrastruct;
using FINANS.IRepository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FINANS.Services
{
    public class CARIFISService : ICARIFISService
    {

        private readonly ICARIFISRepository _CARIFISRepository;

        public CARIFISService(ICARIFISRepository _CARIFISRepository)
        {
            this._CARIFISRepository = _CARIFISRepository;
        }

        public Task<List<CARIFISDTO>> GetCARIFISLAR()
        {
            return _CARIFISRepository.GetAllAsync();
        }

        public Task<List<CARIFISDTO>> GetCARIFISLARById(int id)
        {
            return _CARIFISRepository.GetById(id);
        }

        public Task<bool> CreateCARIFISLARAsync(CARIFISDTO model)
        {
            return  _CARIFISRepository.CreateAsync(model);
        }

        public Task<bool> UpdateCARIFISLARAsync(CARIFISDTO model)
        {
            return _CARIFISRepository.UpdateAsync(model);
            
        }

        public Task<bool> DeleteCARIFISLARAsync(int ID)
        {
            
                return _CARIFISRepository.DeleteAsync(ID);
           
        }

        public void Dispose()
        {
      
        }
    }
}
