

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Depart_Gorev_ParamsServices : IDepart_Gorev_ParamsServices
    {
        private readonly IDepart_Gorev_ParamsRepository _Depart_Gorev_ParamsRepository;

        public  Depart_Gorev_ParamsServices(IDepart_Gorev_ParamsRepository _Depart_Gorev_ParamsRepository)
        {
            this._Depart_Gorev_ParamsRepository = _Depart_Gorev_ParamsRepository;
        }

        public async Task<bool> CreateDepart_Gorev_ParamsAsync(Depart_Gorev_Params model)
        {
            return await _Depart_Gorev_ParamsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteDepart_Gorev_ParamsAsync(int ID)
        {
            return await _Depart_Gorev_ParamsRepository.DeleteAsync(ID);
        }

        public async Task<List<Depart_Gorev_Params>> GetDepart_Gorev_Params()
        {
            return await _Depart_Gorev_ParamsRepository.GetAllAsync();
        }

        public async Task<Depart_Gorev_Params> GetDepart_Gorev_ParamsById(int ID)
        {
            return await _Depart_Gorev_ParamsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateDepart_Gorev_ParamsAsync(Depart_Gorev_Params model)
        {
            return await _Depart_Gorev_ParamsRepository.UpdateAsync(model);
        }
    }


}



