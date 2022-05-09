
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMalz_ImagesServices
    {

        public Task<List<Malz_Images>> GetMalz_Images();
        
        public Task<Malz_Images> GetMalz_ImagesById(int id);
        
        public Task<bool> CreateMalz_ImagesAsync(Malz_Images model);
        
        public Task<bool> UpdateMalz_ImagesAsync(Malz_Images model);
 
        public Task<bool> DeleteMalz_ImagesAsync(int ID);   
    }
}


