
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IRota_TanımlarıServices
    {

        public Task<List<Rota_Tanımları>> GetRota_Tanımları();
        
        public Task<Rota_Tanımları> GetRota_TanımlarıById(int id);
        
        public Task<bool> CreateRota_TanımlarıAsync(Rota_Tanımları model);
        
        public Task<bool> UpdateRota_TanımlarıAsync(Rota_Tanımları model);
 
        public Task<bool> DeleteRota_TanımlarıAsync(int ID);   
    }
}


