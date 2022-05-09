
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IPersonel_Aile_BilgileriServices
    {

        public Task<List<Personel_Aile_Bilgileri>> GetPersonel_Aile_Bilgileri();
        
        public Task<Personel_Aile_Bilgileri> GetPersonel_Aile_BilgileriById(int id);
        
        public Task<bool> CreatePersonel_Aile_BilgileriAsync(Personel_Aile_Bilgileri model);
        
        public Task<bool> UpdatePersonel_Aile_BilgileriAsync(Personel_Aile_Bilgileri model);
 
        public Task<bool> DeletePersonel_Aile_BilgileriAsync(int ID);   
    }
}


