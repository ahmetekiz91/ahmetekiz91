
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
    public class OdemelerRepository : BaseRepository, IRepository.IOdemelerRepository
    {

        public OdemelerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Odemeler entity)
        {

            try
            {
                var query = "AddOdemeler";
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

        public async Task<bool> DeleteAsync(object Ode_ID)
        {
            try
            {
                var query = "DeleteOdemeler";

                var parameters = new DynamicParameters();
                parameters.Add("Ode_ID", (Ode_ID == null ? 0 : Convert.ToInt32(Ode_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Odemeler>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Odemeler>> GetAllAsync()
        {
            try
            {

                var query = "getOdemeler";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Odemeler>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Odemeler> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Odemeler WHERE Ode_ID = @Ode_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Ode_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Odemeler>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Odemeler entity)
        {
            try
            {
                var query = "UpdateOdemelerDetails";
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


