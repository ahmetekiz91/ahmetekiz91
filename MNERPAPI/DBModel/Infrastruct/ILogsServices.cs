
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface ILogsServices
    {

        public Task<List<Logs>> GetLogs();
        
        public Task<Logs> GetLogsById(int id);
        
        public Task<bool> CreateLogsAsync(Logs model);
        
        public Task<bool> UpdateLogsAsync(Logs model);
 
        public Task<bool> DeleteLogsAsync(int ID);   
    }
}


