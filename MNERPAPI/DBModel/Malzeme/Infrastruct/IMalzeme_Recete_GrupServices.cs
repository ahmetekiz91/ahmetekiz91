
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMalzeme_Recete_GrupServices
    {

        public Task<List<Malzeme_Recete_Grup>> GetMalzeme_Recete_Grup();
        
        public Task<Malzeme_Recete_Grup> GetMalzeme_Recete_GrupById(int id);
        
        public Task<bool> CreateMalzeme_Recete_GrupAsync(Malzeme_Recete_Grup model);
        
        public Task<bool> UpdateMalzeme_Recete_GrupAsync(Malzeme_Recete_Grup model);
 
        public Task<bool> DeleteMalzeme_Recete_GrupAsync(int ID);   
    }
}


