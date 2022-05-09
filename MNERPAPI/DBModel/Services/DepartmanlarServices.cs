

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class DepartmanlarServices : IDepartmanlarServices
    {
        private readonly IDepartmanlarRepository _DepartmanlarRepository;

        public  DepartmanlarServices(IDepartmanlarRepository _DepartmanlarRepository)
        {
            this._DepartmanlarRepository = _DepartmanlarRepository;
        }

        public async Task<bool> CreateDepartmanlarAsync(Departmanlar model)
        {
            return await _DepartmanlarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteDepartmanlarAsync(int ID)
        {
            return await _DepartmanlarRepository.DeleteAsync(ID);
        }

        public async Task<List<Departmanlar>> GetDepartmanlar()
        {
            return await _DepartmanlarRepository.GetAllAsync();
        }

        public async Task<Departmanlar> GetDepartmanlarById(int ID)
        {
            return await _DepartmanlarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateDepartmanlarAsync(Departmanlar model)
        {
            return await _DepartmanlarRepository.UpdateAsync(model);
        }
    }


}



