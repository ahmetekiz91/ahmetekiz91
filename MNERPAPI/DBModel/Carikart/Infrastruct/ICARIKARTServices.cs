
using DBModel.DTO;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ICARIKARTServices:IDisposable
    {

        public Task<List<CARIKARTDTO>> GetCARIKART();
        
        public Task<CARIKARTDTO> GetCARIKARTById(int id);
        
        public Task<bool> CreateCARIKARTAsync(CARIKARTDTO model);
        
        public Task<bool> UpdateCARIKARTAsync(CARIKARTDTO model);
 
        public Task<bool> DeleteCARIKARTAsync(int ID);   
    }
}


