
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
    public class MUH_HAREKETRepository : BaseRepository, IRepository.IMUH_HAREKETRepository
    {

        public MUH_HAREKETRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MUH_HAREKET entity)
        {

            try
            {
                var query = "AddMUH_HAREKET";
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

        public async Task<bool> DeleteAsync(object MUH_HAR_ID)
        {
            try
            {
                var query = "DeleteMUH_HAREKET";

                var parameters = new DynamicParameters();
                parameters.Add("MUH_HAR_ID", (MUH_HAR_ID == null ? 0 : Convert.ToInt32(MUH_HAR_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MUH_HAREKET>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MUH_HAREKET>> GetAllAsync()
        {
            try
            {

                var query = "getMUH_HAREKET";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MUH_HAREKET>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MUH_HAREKET> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MUH_HAREKET WHERE MUH_HAR_ID = @MUH_HAR_ID";
                var parameters = new DynamicParameters();
                parameters.Add("MUH_HAR_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MUH_HAREKET>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MUH_HAREKET entity)
        {
            try
            {
                var query = "UpdateMUH_HAREKETDetails";
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


