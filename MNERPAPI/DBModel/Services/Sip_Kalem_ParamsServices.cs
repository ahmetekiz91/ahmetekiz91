

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Sip_Kalem_ParamsServices : ISip_Kalem_ParamsServices
    {
        private readonly ISip_Kalem_ParamsRepository _Sip_Kalem_ParamsRepository;

        public  Sip_Kalem_ParamsServices(ISip_Kalem_ParamsRepository _Sip_Kalem_ParamsRepository)
        {
            this._Sip_Kalem_ParamsRepository = _Sip_Kalem_ParamsRepository;
        }

        public async Task<bool> CreateSip_Kalem_ParamsAsync(Sip_Kalem_Params model)
        {
            return await _Sip_Kalem_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteSip_Kalem_ParamsAsync(int ID)
        {
            return await _Sip_Kalem_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Sip_Kalem_Params>> GetSip_Kalem_Params()
        {
            return await _Sip_Kalem_ParamsRepository.GetAllAsync();
        }

        public async Task<Sip_Kalem_Params> GetSip_Kalem_ParamsById(int ID)
        {
            return await _Sip_Kalem_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateSip_Kalem_ParamsAsync(Sip_Kalem_Params model)
        {
            return await _Sip_Kalem_ParamsRepository.UpdateAsync(model);
        }
    }


}



