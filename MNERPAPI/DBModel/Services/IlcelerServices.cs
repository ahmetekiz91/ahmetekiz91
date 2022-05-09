

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class IlcelerServices : IIlcelerServices
    {
        private readonly IIlcelerRepository _IlcelerRepository;

        public  IlcelerServices(IIlcelerRepository _IlcelerRepository)
        {
            this._IlcelerRepository = _IlcelerRepository;
        }

        public async Task<bool> CreateIlcelerAsync(Ilceler model)
        {
            return await _IlcelerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteIlcelerAsync(int ID)
        {
            return await _IlcelerRepository.DeleteAsync(ID);
        }

        public async Task<List<Ilceler>> GetIlceler()
        {
            return await _IlcelerRepository.GetAllAsync();
        }

        public async Task<Ilceler> GetIlcelerById(int ID)
        {
            return await _IlcelerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateIlcelerAsync(Ilceler model)
        {
            return await _IlcelerRepository.UpdateAsync(model);
        }
    }


}



