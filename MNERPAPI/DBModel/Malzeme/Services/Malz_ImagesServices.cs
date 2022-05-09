

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Malz_ImagesServices : IMalz_ImagesServices
    {
        private readonly IMalz_ImagesRepository _Malz_ImagesRepository;

        public  Malz_ImagesServices(IMalz_ImagesRepository _Malz_ImagesRepository)
        {
            this._Malz_ImagesRepository = _Malz_ImagesRepository;
        }

        public async Task<bool> CreateMalz_ImagesAsync(Malz_Images model)
        {
            return await _Malz_ImagesRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMalz_ImagesAsync(int ID)
        {
            return await _Malz_ImagesRepository.DeleteAsync(ID);
        }

        public async Task<List<Malz_Images>> GetMalz_Images()
        {
            return await _Malz_ImagesRepository.GetAllAsync();
        }

        public async Task<Malz_Images> GetMalz_ImagesById(int ID)
        {
            return await _Malz_ImagesRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMalz_ImagesAsync(Malz_Images model)
        {
            return await _Malz_ImagesRepository.UpdateAsync(model);
        }
    }


}



