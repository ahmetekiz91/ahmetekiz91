

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Doviz_KurlariServices : IDoviz_KurlariServices
    {
        private readonly IDoviz_KurlariRepository _Doviz_KurlariRepository;

        public  Doviz_KurlariServices(IDoviz_KurlariRepository _Doviz_KurlariRepository)
        {
            this._Doviz_KurlariRepository = _Doviz_KurlariRepository;
        }

        public async Task<bool> CreateDoviz_KurlariAsync(Doviz_Kurlari model)
        {
            return await _Doviz_KurlariRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteDoviz_KurlariAsync(int ID)
        {
            return await _Doviz_KurlariRepository.DeleteAsync(ID);
        }

        public async Task<List<Doviz_Kurlari>> GetDoviz_Kurlari()
        {
            return await _Doviz_KurlariRepository.GetAllAsync();
        }

        public async Task<Doviz_Kurlari> GetDoviz_KurlariById(int ID)
        {
            return await _Doviz_KurlariRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateDoviz_KurlariAsync(Doviz_Kurlari model)
        {
            return await _Doviz_KurlariRepository.UpdateAsync(model);
        }
    }


}



