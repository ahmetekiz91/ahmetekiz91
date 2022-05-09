
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IGorev_NotlariServices
    {

        public Task<List<Gorev_Notlari>> GetGorev_Notlari();
        
        public Task<Gorev_Notlari> GetGorev_NotlariById(int id);
        
        public Task<bool> CreateGorev_NotlariAsync(Gorev_Notlari model);
        
        public Task<bool> UpdateGorev_NotlariAsync(Gorev_Notlari model);
 
        public Task<bool> DeleteGorev_NotlariAsync(int ID);   
    }
}


