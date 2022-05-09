
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IPersonel_VardiyalarServices
    {

        public Task<List<Personel_Vardiyalar>> GetPersonel_Vardiyalar();
        
        public Task<Personel_Vardiyalar> GetPersonel_VardiyalarById(int id);
        
        public Task<bool> CreatePersonel_VardiyalarAsync(Personel_Vardiyalar model);
        
        public Task<bool> UpdatePersonel_VardiyalarAsync(Personel_Vardiyalar model);
 
        public Task<bool> DeletePersonel_VardiyalarAsync(int ID);   
    }
}


