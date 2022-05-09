
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
    public class FIS_HAREKETRepository : BaseRepository, IRepository.IFIS_HAREKETRepository
    {

        public FIS_HAREKETRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(FIS_HAREKET entity)
        {

            try
            {
                var query = "AddFIS_HAREKET";
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

        public async Task<bool> DeleteAsync(object FIS_LINE_ID)
        {
            try
            {
                var query = "DeleteFIS_HAREKET";

                var parameters = new DynamicParameters();
                parameters.Add("FIS_LINE_ID", (FIS_LINE_ID == null ? 0 : Convert.ToInt32(FIS_LINE_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<FIS_HAREKET>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<FIS_HAREKET>> GetAllAsync()
        {
            try
            {

                var query = "getFIS_HAREKET";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<FIS_HAREKET>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<FIS_HAREKET> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM FIS_HAREKET WHERE FIS_LINE_ID = @FIS_LINE_ID";
                var parameters = new DynamicParameters();
                parameters.Add("FIS_LINE_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<FIS_HAREKET>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(FIS_HAREKET entity)
        {
            try
            {
                var query = "UpdateFIS_HAREKETDetails";
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


