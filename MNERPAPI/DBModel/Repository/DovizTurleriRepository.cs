
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
    public class DovizTurleriRepository : BaseRepository, IRepository.IDovizTurleriRepository
    {

        public DovizTurleriRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(DovizTurleri entity)
        {

            try
            {
                var query = "AddDovizTurleri";
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

        public async Task<bool> DeleteAsync(object DOV_ID)
        {
            try
            {
                var query = "DeleteDovizTurleri";

                var parameters = new DynamicParameters();
                parameters.Add("DOV_ID", (DOV_ID == null ? 0 : Convert.ToInt32(DOV_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<DovizTurleri>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<DovizTurleri>> GetAllAsync()
        {
            try
            {

                var query = "getDovizTurleri";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<DovizTurleri>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<DovizTurleri> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM DovizTurleri WHERE DOV_ID = @DOV_ID";
                var parameters = new DynamicParameters();
                parameters.Add("DOV_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<DovizTurleri>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(DovizTurleri entity)
        {
            try
            {
                var query = "UpdateDovizTurleriDetails";
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


