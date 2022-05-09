
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IIstasyonServices
    {

        public Task<List<Istasyon>> GetIstasyon();
        
        public Task<Istasyon> GetIstasyonById(int id);
        
        public Task<bool> CreateIstasyonAsync(Istasyon model);
        
        public Task<bool> UpdateIstasyonAsync(Istasyon model);
 
        public Task<bool> DeleteIstasyonAsync(int ID);   
    }
}


