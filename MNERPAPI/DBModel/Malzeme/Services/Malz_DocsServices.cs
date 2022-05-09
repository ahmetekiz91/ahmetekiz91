

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Malz_DocsServices : IMalz_DocsServices
    {
        private readonly IMalz_DocsRepository _Malz_DocsRepository;

        public  Malz_DocsServices(IMalz_DocsRepository _Malz_DocsRepository)
        {
            this._Malz_DocsRepository = _Malz_DocsRepository;
        }

        public async Task<bool> CreateMalz_DocsAsync(Malz_Docs model)
        {
            return await _Malz_DocsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMalz_DocsAsync(int ID)
        {
            return await _Malz_DocsRepository.DeleteAsync(ID);
        }

        public async Task<List<Malz_Docs>> GetMalz_Docs()
        {
            return await _Malz_DocsRepository.GetAllAsync();
        }

        public async Task<Malz_Docs> GetMalz_DocsById(int ID)
        {
            return await _Malz_DocsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMalz_DocsAsync(Malz_Docs model)
        {
            return await _Malz_DocsRepository.UpdateAsync(model);
        }
    }


}



