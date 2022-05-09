
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
    public class Gorevler_ParamsRepository : BaseRepository, IRepository.IGorevler_ParamsRepository
    {

        public Gorevler_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Gorevler_Params entity)
        {

            try
            {
                var query = "AddGorevler_Params";
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

        public async Task<bool> DeleteAsync(object Gorev_Params_ID)
        {
            try
            {
                var query = "DeleteGorevler_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Gorev_Params_ID", (Gorev_Params_ID == null ? 0 : Convert.ToInt32(Gorev_Params_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Gorevler_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Gorevler_Params>> GetAllAsync()
        {
            try
            {

                var query = "getGorevler_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Gorevler_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Gorevler_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Gorevler_Params WHERE Gorev_Params_ID = @Gorev_Params_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Gorev_Params_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Gorevler_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Gorevler_Params entity)
        {
            try
            {
                var query = "UpdateGorevler_ParamsDetails";
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


