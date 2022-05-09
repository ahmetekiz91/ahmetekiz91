
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITekliflerServices
    {

        public Task<List<Teklifler>> GetTeklifler();
        
        public Task<Teklifler> GetTekliflerById(int id);
        
        public Task<bool> CreateTekliflerAsync(Teklifler model);
        
        public Task<bool> UpdateTekliflerAsync(Teklifler model);
 
        public Task<bool> DeleteTekliflerAsync(int ID);   
    }
}


