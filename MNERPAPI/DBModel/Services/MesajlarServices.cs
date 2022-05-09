

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MesajlarServices : IMesajlarServices
    {
        private readonly IMesajlarRepository _MesajlarRepository;

        public  MesajlarServices(IMesajlarRepository _MesajlarRepository)
        {
            this._MesajlarRepository = _MesajlarRepository;
        }

        public async Task<bool> CreateMesajlarAsync(Mesajlar model)
        {
            return await _MesajlarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMesajlarAsync(int ID)
        {
            return await _MesajlarRepository.DeleteAsync(ID);
        }

        public async Task<List<Mesajlar>> GetMesajlar()
        {
            return await _MesajlarRepository.GetAllAsync();
        }

        public async Task<Mesajlar> GetMesajlarById(int ID)
        {
            return await _MesajlarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMesajlarAsync(Mesajlar model)
        {
            return await _MesajlarRepository.UpdateAsync(model);
        }
    }


}



