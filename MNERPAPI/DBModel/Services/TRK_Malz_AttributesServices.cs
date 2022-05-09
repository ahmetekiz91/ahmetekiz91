

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class TRK_Malz_AttributesServices : ITRK_Malz_AttributesServices
    {
        private readonly ITRK_Malz_AttributesRepository _TRK_Malz_AttributesRepository;

        public  TRK_Malz_AttributesServices(ITRK_Malz_AttributesRepository _TRK_Malz_AttributesRepository)
        {
            this._TRK_Malz_AttributesRepository = _TRK_Malz_AttributesRepository;
        }

        public async Task<bool> CreateTRK_Malz_AttributesAsync(TRK_Malz_Attributes model)
        {
            return await _TRK_Malz_AttributesRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTRK_Malz_AttributesAsync(int ID)
        {
            return await _TRK_Malz_AttributesRepository.DeleteAsync(ID);
        }

        public async Task<List<TRK_Malz_Attributes>> GetTRK_Malz_Attributes()
        {
            return await _TRK_Malz_AttributesRepository.GetAllAsync();
        }

        public async Task<TRK_Malz_Attributes> GetTRK_Malz_AttributesById(int ID)
        {
            return await _TRK_Malz_AttributesRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTRK_Malz_AttributesAsync(TRK_Malz_Attributes model)
        {
            return await _TRK_Malz_AttributesRepository.UpdateAsync(model);
        }
    }


}



