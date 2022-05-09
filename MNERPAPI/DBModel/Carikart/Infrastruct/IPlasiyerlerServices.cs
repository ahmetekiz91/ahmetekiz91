
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IPlasiyerlerServices:IDisposable
    {

        public Task<List<Plasiyerler>> GetPlasiyerler();
        
        public Task<Plasiyerler> GetPlasiyerlerById(int id);
        
        public Task<bool> CreatePlasiyerlerAsync(Plasiyerler model);
        
        public Task<bool> UpdatePlasiyerlerAsync(Plasiyerler model);
 
        public Task<bool> DeletePlasiyerlerAsync(int ID);
 
    }
}


