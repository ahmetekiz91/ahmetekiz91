
using FINANS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FINANS.Infrastruce
{
    public interface IPARA_HAREKETServices
    {

        public Task<List<PARA_HAREKET>> GetPARA_HAREKET();
        
        public Task<PARA_HAREKET> GetPARA_HAREKETById(int id);
        
        public Task<bool> CreatePARA_HAREKETAsync(PARA_HAREKET model);
        
        public Task<bool> UpdatePARA_HAREKETAsync(PARA_HAREKET model);
 
        public Task<bool> DeletePARA_HAREKETAsync(int ID);   
    }
}


