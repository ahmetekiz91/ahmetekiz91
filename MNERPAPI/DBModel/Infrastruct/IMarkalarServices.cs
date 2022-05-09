
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMarkalarServices
    {

        public Task<List<Markalar>> GetMarkalar();
        
        public Task<Markalar> GetMarkalarById(int id);
        
        public Task<bool> CreateMarkalarAsync(Markalar model);
        
        public Task<bool> UpdateMarkalarAsync(Markalar model);
 
        public Task<bool> DeleteMarkalarAsync(int ID);   
    }
}


