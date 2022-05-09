

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
    public class FISLERServices : IFISLERServices
    {
        private readonly IFISLERRepository _FISLERRepository;

        public  FISLERServices(IFISLERRepository _FISLERRepository)
        {
            this._FISLERRepository = _FISLERRepository;
        }

        public async Task<bool> CreateFISLERAsync(FISLER model)
        {
            return await _FISLERRepository.CreateAsync(model);
        }
      


        public async Task<bool> DeleteFISLERAsync(int ID)
        {
            return await _FISLERRepository.DeleteAsync(ID);
        }

        public void Dispose()
        {
            
        }

        public async Task<List<FISLER>> GetFISLER()
        {
            return await _FISLERRepository.GetAllAsync();
        }

        public async Task<FISLER> GetFISLERById(int ID)
        {
            return await _FISLERRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateFISLERAsync(FISLER model)
        {
            return await _FISLERRepository.UpdateAsync(model);
        }
    }


}



