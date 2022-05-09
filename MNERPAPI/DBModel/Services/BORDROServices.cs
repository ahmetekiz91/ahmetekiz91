

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class BORDROServices : IBORDROServices
    {
        private readonly IBORDRORepository _BORDRORepository;

        public  BORDROServices(IBORDRORepository _BORDRORepository)
        {
            this._BORDRORepository = _BORDRORepository;
        }

        public async Task<bool> CreateBORDROAsync(BORDRO model)
        {
            return await _BORDRORepository.CreateAsync(model);
        }

        public async Task<bool> DeleteBORDROAsync(int ID)
        {
            return await _BORDRORepository.DeleteAsync(ID);
        }

        public async Task<List<BORDRO>> GetBORDRO()
        {
            return await _BORDRORepository.GetAllAsync();
        }

        public async Task<BORDRO> GetBORDROById(int ID)
        {
            return await _BORDRORepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateBORDROAsync(BORDRO model)
        {
            return await _BORDRORepository.UpdateAsync(model);
        }
    }


}



