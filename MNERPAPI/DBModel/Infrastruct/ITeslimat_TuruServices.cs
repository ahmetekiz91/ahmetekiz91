
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ITeslimat_TuruServices
    {

        public Task<List<Teslimat_Turu>> GetTeslimat_Turu();
        
        public Task<Teslimat_Turu> GetTeslimat_TuruById(int id);
        
        public Task<bool> CreateTeslimat_TuruAsync(Teslimat_Turu model);
        
        public Task<bool> UpdateTeslimat_TuruAsync(Teslimat_Turu model);
 
        public Task<bool> DeleteTeslimat_TuruAsync(int ID);   
    }
}


