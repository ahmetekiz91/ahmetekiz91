

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Dep_Ici_Gorev_AtamaServices : IDep_Ici_Gorev_AtamaServices
    {
        private readonly IDep_Ici_Gorev_AtamaRepository _Dep_Ici_Gorev_AtamaRepository;

        public  Dep_Ici_Gorev_AtamaServices(IDep_Ici_Gorev_AtamaRepository _Dep_Ici_Gorev_AtamaRepository)
        {
            this._Dep_Ici_Gorev_AtamaRepository = _Dep_Ici_Gorev_AtamaRepository;
        }

        public async Task<bool> CreateDep_Ici_Gorev_AtamaAsync(Dep_Ici_Gorev_Atama model)
        {
            return await _Dep_Ici_Gorev_AtamaRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteDep_Ici_Gorev_AtamaAsync(int ID)
        {
            return await _Dep_Ici_Gorev_AtamaRepository.DeleteAsync(ID);
        }

        public async Task<List<Dep_Ici_Gorev_Atama>> GetDep_Ici_Gorev_Atama()
        {
            return await _Dep_Ici_Gorev_AtamaRepository.GetAllAsync();
        }

        public async Task<Dep_Ici_Gorev_Atama> GetDep_Ici_Gorev_AtamaById(int ID)
        {
            return await _Dep_Ici_Gorev_AtamaRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateDep_Ici_Gorev_AtamaAsync(Dep_Ici_Gorev_Atama model)
        {
            return await _Dep_Ici_Gorev_AtamaRepository.UpdateAsync(model);
        }
    }


}



