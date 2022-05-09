
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
    public class Talepler_ParamsRepository : BaseRepository, IRepository.ITalepler_ParamsRepository
    {

        public Talepler_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Talepler_Params entity)
        {

            try
            {
                var query = "AddTalepler_Params";
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

        public async Task<bool> DeleteAsync(object Tlp_Param_ID)
        {
            try
            {
                var query = "DeleteTalepler_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Tlp_Param_ID", (Tlp_Param_ID == null ? 0 : Convert.ToInt32(Tlp_Param_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Talepler_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Talepler_Params>> GetAllAsync()
        {
            try
            {

                var query = "getTalepler_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Talepler_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Talepler_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Talepler_Params WHERE Tlp_Param_ID = @Tlp_Param_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Tlp_Param_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Talepler_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Talepler_Params entity)
        {
            try
            {
                var query = "UpdateTalepler_ParamsDetails";
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


