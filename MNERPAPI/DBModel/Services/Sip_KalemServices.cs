

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Sip_KalemServices : ISip_KalemServices
    {
        private readonly ISip_KalemRepository _Sip_KalemRepository;

        public  Sip_KalemServices(ISip_KalemRepository _Sip_KalemRepository)
        {
            this._Sip_KalemRepository = _Sip_KalemRepository;
        }

        public async Task<bool> CreateSip_KalemAsync(Sip_Kalem model)
        {
            return await _Sip_KalemRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteSip_KalemAsync(int ID)
        {
            return await _Sip_KalemRepository.DeleteAsync(ID);
        }

        public async Task<List<Sip_Kalem>> GetSip_Kalem()
        {
            return await _Sip_KalemRepository.GetAllAsync();
        }

        public async Task<Sip_Kalem> GetSip_KalemById(int ID)
        {
            return await _Sip_KalemRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateSip_KalemAsync(Sip_Kalem model)
        {
            return await _Sip_KalemRepository.UpdateAsync(model);
        }
    }


}



