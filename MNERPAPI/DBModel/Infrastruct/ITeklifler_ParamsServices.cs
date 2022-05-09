
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITeklifler_ParamsServices
    {

        public Task<List<Teklifler_Params>> GetTeklifler_Params();
        
        public Task<Teklifler_Params> GetTeklifler_ParamsById(int id);
        
        public Task<bool> CreateTeklifler_ParamsAsync(Teklifler_Params model);
        
        public Task<bool> UpdateTeklifler_ParamsAsync(Teklifler_Params model);
 
        public Task<bool> DeleteTeklifler_ParamsAsync(int ID);   
    }
}


