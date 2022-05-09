
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IKredi_KartlariServices
    {

        public Task<List<Kredi_Kartlari>> GetKredi_Kartlari();
        
        public Task<Kredi_Kartlari> GetKredi_KartlariById(int id);
        
        public Task<bool> CreateKredi_KartlariAsync(Kredi_Kartlari model);
        
        public Task<bool> UpdateKredi_KartlariAsync(Kredi_Kartlari model);
 
        public Task<bool> DeleteKredi_KartlariAsync(int ID);   
    }
}


