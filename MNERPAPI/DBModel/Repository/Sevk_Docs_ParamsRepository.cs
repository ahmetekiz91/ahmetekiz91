
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
    public class Sevk_Docs_ParamsRepository : BaseRepository, IRepository.ISevk_Docs_ParamsRepository
    {

        public Sevk_Docs_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Sevk_Docs_Params entity)
        {

            try
            {
                var query = "AddSevk_Docs_Params";
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

        public async Task<bool> DeleteAsync(object Sevk_Docs_Params_ID)
        {
            try
            {
                var query = "DeleteSevk_Docs_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Sevk_Docs_Params_ID", (Sevk_Docs_Params_ID == null ? 0 : Convert.ToInt32(Sevk_Docs_Params_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Sevk_Docs_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Sevk_Docs_Params>> GetAllAsync()
        {
            try
            {

                var query = "getSevk_Docs_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Sevk_Docs_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Sevk_Docs_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Sevk_Docs_Params WHERE Sevk_Docs_Params_ID = @Sevk_Docs_Params_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Sevk_Docs_Params_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Sevk_Docs_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Sevk_Docs_Params entity)
        {
            try
            {
                var query = "UpdateSevk_Docs_ParamsDetails";
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


