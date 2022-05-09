
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IDepart_Gorev_ParamsServices
    {

        public Task<List<Depart_Gorev_Params>> GetDepart_Gorev_Params();
        
        public Task<Depart_Gorev_Params> GetDepart_Gorev_ParamsById(int id);
        
        public Task<bool> CreateDepart_Gorev_ParamsAsync(Depart_Gorev_Params model);
        
        public Task<bool> UpdateDepart_Gorev_ParamsAsync(Depart_Gorev_Params model);
 
        public Task<bool> DeleteDepart_Gorev_ParamsAsync(int ID);   
    }
}


