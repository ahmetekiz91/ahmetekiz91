
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
    public class Sevk_Plani_ParamsRepository : BaseRepository, IRepository.ISevk_Plani_ParamsRepository
    {

        public Sevk_Plani_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Sevk_Plani_Params entity)
        {

            try
            {
                var query = "AddSevk_Plani_Params";
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

        public async Task<bool> DeleteAsync(object Sevk_Plani_Params_ID)
        {
            try
            {
                var query = "DeleteSevk_Plani_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Sevk_Plani_Params_ID", (Sevk_Plani_Params_ID == null ? 0 : Convert.ToInt32(Sevk_Plani_Params_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Sevk_Plani_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Sevk_Plani_Params>> GetAllAsync()
        {
            try
            {

                var query = "getSevk_Plani_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Sevk_Plani_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Sevk_Plani_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Sevk_Plani_Params WHERE Sevk_Plani_Params_ID = @Sevk_Plani_Params_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Sevk_Plani_Params_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Sevk_Plani_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Sevk_Plani_Params entity)
        {
            try
            {
                var query = "UpdateSevk_Plani_ParamsDetails";
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


