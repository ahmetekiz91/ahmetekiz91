
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ICalisma_SaatiServices
    {

        public Task<List<Calisma_Saati>> GetCalisma_Saati();
        
        public Task<Calisma_Saati> GetCalisma_SaatiById(int id);
        
        public Task<bool> CreateCalisma_SaatiAsync(Calisma_Saati model);
        
        public Task<bool> UpdateCalisma_SaatiAsync(Calisma_Saati model);
 
        public Task<bool> DeleteCalisma_SaatiAsync(int ID);   
    }
}


