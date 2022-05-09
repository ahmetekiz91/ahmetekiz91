
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IRota_Tanimlari_ParamsServices
    {

        public Task<List<Rota_Tanimlari_Params>> GetRota_Tanimlari_Params();
        
        public Task<Rota_Tanimlari_Params> GetRota_Tanimlari_ParamsById(int id);
        
        public Task<bool> CreateRota_Tanimlari_ParamsAsync(Rota_Tanimlari_Params model);
        
        public Task<bool> UpdateRota_Tanimlari_ParamsAsync(Rota_Tanimlari_Params model);
 
        public Task<bool> DeleteRota_Tanimlari_ParamsAsync(int ID);   
    }
}


