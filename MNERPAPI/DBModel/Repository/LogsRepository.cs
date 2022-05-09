
using Dapper;
using DBModel.Model;
using DBModel.Utility;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public class LogsRepository : BaseRepository, IRepository.ILogsRepository
    {

        public LogsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Logs entity)
        {

            try
            {
                var query = "AddLogs";
                using (var connection = CreateConnection())
                {
                    var res = (await connection.ExecuteAsync(query, entity)); return true;
                }
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
        }

        public async Task<bool> DeleteAsync(object Log_ID)
        {
            try
            {
                var query = "DeleteLogs";

                var parameters = new DynamicParameters();
                parameters.Add("Log_ID", (Log_ID == null ? 0 : Convert.ToInt32(Log_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Logs>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Logs>> GetAllAsync()
        {
            try
            {

                var query = "getLogs";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Logs>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Logs> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Logs WHERE Log_ID = @Log_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Log_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Logs>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Logs entity)
        {
            try
            {
                var query = "UpdateLogsDetails";
                using (var connection = CreateConnection())
                {
                    var res = (await connection.ExecuteAsync(query, entity));
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
        }

    }
}


