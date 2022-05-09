
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IDoviz_KurlariServices
    {

        public Task<List<Doviz_Kurlari>> GetDoviz_Kurlari();
        
        public Task<Doviz_Kurlari> GetDoviz_KurlariById(int id);
        
        public Task<bool> CreateDoviz_KurlariAsync(Doviz_Kurlari model);
        
        public Task<bool> UpdateDoviz_KurlariAsync(Doviz_Kurlari model);
 
        public Task<bool> DeleteDoviz_KurlariAsync(int ID);   
    }
}


