
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IDepartmanlarServices
    {

        public Task<List<Departmanlar>> GetDepartmanlar();
        
        public Task<Departmanlar> GetDepartmanlarById(int id);
        
        public Task<bool> CreateDepartmanlarAsync(Departmanlar model);
        
        public Task<bool> UpdateDepartmanlarAsync(Departmanlar model);
 
        public Task<bool> DeleteDepartmanlarAsync(int ID);   
    }
}


