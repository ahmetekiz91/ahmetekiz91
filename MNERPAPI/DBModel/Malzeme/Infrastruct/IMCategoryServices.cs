
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMCategoryServices
    {

        public Task<List<MCategory>> GetMCategory();
        
        public Task<MCategory> GetMCategoryById(int id);
        
        public Task<bool> CreateMCategoryAsync(MCategory model);
        
        public Task<bool> UpdateMCategoryAsync(MCategory model);
 
        public Task<bool> DeleteMCategoryAsync(int ID);   
    }
}


