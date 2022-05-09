
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IGorev_TalepServices
    {

        public Task<List<Gorev_Talep>> GetGorev_Talep();
        
        public Task<Gorev_Talep> GetGorev_TalepById(int id);
        
        public Task<bool> CreateGorev_TalepAsync(Gorev_Talep model);
        
        public Task<bool> UpdateGorev_TalepAsync(Gorev_Talep model);
 
        public Task<bool> DeleteGorev_TalepAsync(int ID);   
    }
}


