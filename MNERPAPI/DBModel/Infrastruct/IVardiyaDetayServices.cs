
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IVardiyaDetayServices
    {

        public Task<List<VardiyaDetay>> GetVardiyaDetay();
        
        public Task<VardiyaDetay> GetVardiyaDetayById(int id);
        
        public Task<bool> CreateVardiyaDetayAsync(VardiyaDetay model);
        
        public Task<bool> UpdateVardiyaDetayAsync(VardiyaDetay model);
 
        public Task<bool> DeleteVardiyaDetayAsync(int ID);   
    }
}


