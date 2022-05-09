

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class MarkalarServices : IMarkalarServices
    {
        private readonly IMarkalarRepository _MarkalarRepository;

        public  MarkalarServices(IMarkalarRepository _MarkalarRepository)
        {
            this._MarkalarRepository = _MarkalarRepository;
        }

        public async Task<bool> CreateMarkalarAsync(Markalar model)
        {
            return await _MarkalarRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteMarkalarAsync(int ID)
        {
            return await _MarkalarRepository.DeleteAsync(ID);
        }

        public async Task<List<Markalar>> GetMarkalar()
        {
            return await _MarkalarRepository.GetAllAsync();
        }

        public async Task<Markalar> GetMarkalarById(int ID)
        {
            return await _MarkalarRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateMarkalarAsync(Markalar model)
        {
            return await _MarkalarRepository.UpdateAsync(model);
        }
    }


}



