

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Sevk_DocsServices : ISevk_DocsServices
    {
        private readonly ISevk_DocsRepository _Sevk_DocsRepository;

        public  Sevk_DocsServices(ISevk_DocsRepository _Sevk_DocsRepository)
        {
            this._Sevk_DocsRepository = _Sevk_DocsRepository;
        }

        public async Task<bool> CreateSevk_DocsAsync(Sevk_Docs model)
        {
            return await _Sevk_DocsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteSevk_DocsAsync(int ID)
        {
            return await _Sevk_DocsRepository.DeleteAsync(ID);
        }

        public async Task<List<Sevk_Docs>> GetSevk_Docs()
        {
            return await _Sevk_DocsRepository.GetAllAsync();
        }

        public async Task<Sevk_Docs> GetSevk_DocsById(int ID)
        {
            return await _Sevk_DocsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateSevk_DocsAsync(Sevk_Docs model)
        {
            return await _Sevk_DocsRepository.UpdateAsync(model);
        }
    }


}



