
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
    public class GiderlerRepository : BaseRepository, IRepository.IGiderlerRepository
    {

        public GiderlerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Giderler entity)
        {

            try
            {
                var query = "AddGiderler";
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

        public async Task<bool> DeleteAsync(object GID_ID)
        {
            try
            {
                var query = "DeleteGiderler";

                var parameters = new DynamicParameters();
                parameters.Add("GID_ID", (GID_ID == null ? 0 : Convert.ToInt32(GID_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Giderler>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Giderler>> GetAllAsync()
        {
            try
            {

                var query = "getGiderler";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Giderler>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Giderler> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Giderler WHERE GID_ID = @GID_ID";
                var parameters = new DynamicParameters();
                parameters.Add("GID_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Giderler>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Giderler entity)
        {
            try
            {
                var query = "UpdateGiderlerDetails";
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


