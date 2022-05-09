
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IBOLGELERServices
    {

        public Task<List<BOLGELER>> GetBOLGELER();
        
        public Task<BOLGELER> GetBOLGELERById(int id);
        
        public Task<bool> CreateBOLGELERAsync(BOLGELER model);
        
        public Task<bool> UpdateBOLGELERAsync(BOLGELER model);
 
        public Task<bool> DeleteBOLGELERAsync(int ID);   
    }
}


