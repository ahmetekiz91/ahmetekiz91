

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class LogsServices : ILogsServices
    {
        private readonly ILogsRepository _LogsRepository;

        public  LogsServices(ILogsRepository _LogsRepository)
        {
            this._LogsRepository = _LogsRepository;
        }

        public async Task<bool> CreateLogsAsync(Logs model)
        {
            return await _LogsRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteLogsAsync(int ID)
        {
            return await _LogsRepository.DeleteAsync(ID);
        }

        public async Task<List<Logs>> GetLogs()
        {
            return await _LogsRepository.GetAllAsync();
        }

        public async Task<Logs> GetLogsById(int ID)
        {
            return await _LogsRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateLogsAsync(Logs model)
        {
            return await _LogsRepository.UpdateAsync(model);
        }
    }


}



