
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IDepart_GorevlerServices
    {

        public Task<List<Depart_Gorevler>> GetDepart_Gorevler();
        
        public Task<Depart_Gorevler> GetDepart_GorevlerById(int id);
        
        public Task<bool> CreateDepart_GorevlerAsync(Depart_Gorevler model);
        
        public Task<bool> UpdateDepart_GorevlerAsync(Depart_Gorevler model);
 
        public Task<bool> DeleteDepart_GorevlerAsync(int ID);   
    }
}


