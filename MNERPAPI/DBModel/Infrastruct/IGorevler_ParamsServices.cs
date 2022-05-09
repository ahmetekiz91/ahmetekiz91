
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IGorevler_ParamsServices
    {

        public Task<List<Gorevler_Params>> GetGorevler_Params();
        
        public Task<Gorevler_Params> GetGorevler_ParamsById(int id);
        
        public Task<bool> CreateGorevler_ParamsAsync(Gorevler_Params model);
        
        public Task<bool> UpdateGorevler_ParamsAsync(Gorevler_Params model);
 
        public Task<bool> DeleteGorevler_ParamsAsync(int ID);   
    }
}


