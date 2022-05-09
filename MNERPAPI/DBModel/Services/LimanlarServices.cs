

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class LimanlarServices : ILimanlarServices
    {
        private readonly ILimanlarRepository _LimanlarRepository;

        public  LimanlarServices(ILimanlarRepository _LimanlarRepository)
        {
            this._LimanlarRepository = _LimanlarRepository;
        }

        public async Task<bool> CreateLimanlarAsync(Limanlar model)
        {
            return await _LimanlarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteLimanlarAsync(int ID)
        {
            return await _LimanlarRepository.DeleteAsync(ID);
        }

        public async Task<List<Limanlar>> GetLimanlar()
        {
            return await _LimanlarRepository.GetAllAsync();
        }

        public async Task<Limanlar> GetLimanlarById(int ID)
        {
            return await _LimanlarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateLimanlarAsync(Limanlar model)
        {
            return await _LimanlarRepository.UpdateAsync(model);
        }
    }


}



