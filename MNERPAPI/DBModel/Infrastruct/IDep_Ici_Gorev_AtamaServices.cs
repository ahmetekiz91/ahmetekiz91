
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IDep_Ici_Gorev_AtamaServices
    {

        public Task<List<Dep_Ici_Gorev_Atama>> GetDep_Ici_Gorev_Atama();
        
        public Task<Dep_Ici_Gorev_Atama> GetDep_Ici_Gorev_AtamaById(int id);
        
        public Task<bool> CreateDep_Ici_Gorev_AtamaAsync(Dep_Ici_Gorev_Atama model);
        
        public Task<bool> UpdateDep_Ici_Gorev_AtamaAsync(Dep_Ici_Gorev_Atama model);
 
        public Task<bool> DeleteDep_Ici_Gorev_AtamaAsync(int ID);   
    }
}


