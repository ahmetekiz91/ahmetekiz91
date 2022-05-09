
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
    public class Teklifler_ParamsRepository : BaseRepository, IRepository.ITeklifler_ParamsRepository
    {

        public Teklifler_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Teklifler_Params entity)
        {

            try
            {
                var query = "AddTeklifler_Params";
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

        public async Task<bool> DeleteAsync(object Teklif_Param_ID)
        {
            try
            {
                var query = "DeleteTeklifler_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Teklif_Param_ID", (Teklif_Param_ID == null ? 0 : Convert.ToInt32(Teklif_Param_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Teklifler_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Teklifler_Params>> GetAllAsync()
        {
            try
            {

                var query = "getTeklifler_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Teklifler_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Teklifler_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Teklifler_Params WHERE Teklif_Param_ID = @Teklif_Param_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Teklif_Param_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Teklifler_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Teklifler_Params entity)
        {
            try
            {
                var query = "UpdateTeklifler_ParamsDetails";
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


