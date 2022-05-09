
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IDovizTurleriServices
    {

        public Task<List<DovizTurleri>> GetDovizTurleri();
        
        public Task<DovizTurleri> GetDovizTurleriById(int id);
        
        public Task<bool> CreateDovizTurleriAsync(DovizTurleri model);
        
        public Task<bool> UpdateDovizTurleriAsync(DovizTurleri model);
 
        public Task<bool> DeleteDovizTurleriAsync(int ID);   
    }
}


