

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Uretim_Planlama_Uretim_OperatorlerServices : IUretim_Planlama_Uretim_OperatorlerServices
    {
        private readonly IUretim_Planlama_Uretim_OperatorlerRepository _Uretim_Planlama_Uretim_OperatorlerRepository;

        public  Uretim_Planlama_Uretim_OperatorlerServices(IUretim_Planlama_Uretim_OperatorlerRepository _Uretim_Planlama_Uretim_OperatorlerRepository)
        {
            this._Uretim_Planlama_Uretim_OperatorlerRepository = _Uretim_Planlama_Uretim_OperatorlerRepository;
        }

        public async Task<bool> CreateUretim_Planlama_Uretim_OperatorlerAsync(Uretim_Planlama_Uretim_Operatorler model)
        {
            return await _Uretim_Planlama_Uretim_OperatorlerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteUretim_Planlama_Uretim_OperatorlerAsync(int ID)
        {
            return await _Uretim_Planlama_Uretim_OperatorlerRepository.DeleteAsync(ID);
        }

        public async Task<List<Uretim_Planlama_Uretim_Operatorler>> GetUretim_Planlama_Uretim_Operatorler()
        {
            return await _Uretim_Planlama_Uretim_OperatorlerRepository.GetAllAsync();
        }

        public async Task<Uretim_Planlama_Uretim_Operatorler> GetUretim_Planlama_Uretim_OperatorlerById(int ID)
        {
            return await _Uretim_Planlama_Uretim_OperatorlerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateUretim_Planlama_Uretim_OperatorlerAsync(Uretim_Planlama_Uretim_Operatorler model)
        {
            return await _Uretim_Planlama_Uretim_OperatorlerRepository.UpdateAsync(model);
        }
    }


}



