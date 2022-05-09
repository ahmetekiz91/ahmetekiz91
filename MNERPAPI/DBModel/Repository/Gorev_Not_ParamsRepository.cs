
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
    public class Gorev_Not_ParamsRepository : BaseRepository, IRepository.IGorev_Not_ParamsRepository
    {

        public Gorev_Not_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Gorev_Not_Params entity)
        {

            try
            {
                var query = "AddGorev_Not_Params";
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

        public async Task<bool> DeleteAsync(object Gorev_Not_Params_ID)
        {
            try
            {
                var query = "DeleteGorev_Not_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Gorev_Not_Params_ID", (Gorev_Not_Params_ID == null ? 0 : Convert.ToInt32(Gorev_Not_Params_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Gorev_Not_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Gorev_Not_Params>> GetAllAsync()
        {
            try
            {

                var query = "getGorev_Not_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Gorev_Not_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Gorev_Not_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Gorev_Not_Params WHERE Gorev_Not_Params_ID = @Gorev_Not_Params_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Gorev_Not_Params_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Gorev_Not_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Gorev_Not_Params entity)
        {
            try
            {
                var query = "UpdateGorev_Not_ParamsDetails";
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


