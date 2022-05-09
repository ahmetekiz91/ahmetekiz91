
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IDuyurularServices
    {

        public Task<List<Duyurular>> GetDuyurular();
        
        public Task<Duyurular> GetDuyurularById(int id);
        
        public Task<bool> CreateDuyurularAsync(Duyurular model);
        
        public Task<bool> UpdateDuyurularAsync(Duyurular model);
 
        public Task<bool> DeleteDuyurularAsync(int ID);   
    }
}


