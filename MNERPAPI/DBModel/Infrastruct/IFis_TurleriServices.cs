
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IFis_TurleriServices
    {

        public Task<List<Fis_Turleri>> GetFis_Turleri();
        
        public Task<Fis_Turleri> GetFis_TurleriById(int id);
        
        public Task<bool> CreateFis_TurleriAsync(Fis_Turleri model);
        
        public Task<bool> UpdateFis_TurleriAsync(Fis_Turleri model);
 
        public Task<bool> DeleteFis_TurleriAsync(int ID);   
    }
}


