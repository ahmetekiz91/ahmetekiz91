

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class BOLGELERServices : IBOLGELERServices
    {
        private readonly IBOLGELERRepository _BOLGELERRepository;

        public  BOLGELERServices(IBOLGELERRepository _BOLGELERRepository)
        {
            this._BOLGELERRepository = _BOLGELERRepository;
        }

        public async Task<bool> CreateBOLGELERAsync(BOLGELER model)
        {
            return await _BOLGELERRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteBOLGELERAsync(int ID)
        {
            return await _BOLGELERRepository.DeleteAsync(ID);
        }

        public async Task<List<BOLGELER>> GetBOLGELER()
        {
            return await _BOLGELERRepository.GetAllAsync();
        }

        public async Task<BOLGELER> GetBOLGELERById(int ID)
        {
            return await _BOLGELERRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateBOLGELERAsync(BOLGELER model)
        {
            return await _BOLGELERRepository.UpdateAsync(model);
        }

    }


}



