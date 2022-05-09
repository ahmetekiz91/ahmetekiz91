
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
    public class Sevkiyat_ParamsRepository : BaseRepository, IRepository.ISevkiyat_ParamsRepository
    {

        public Sevkiyat_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Sevkiyat_Params entity)
        {

            try
            {
                var query = "AddSevkiyat_Params";
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

        public async Task<bool> DeleteAsync(object Sevkiyat_Params_ID)
        {
            try
            {
                var query = "DeleteSevkiyat_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Sevkiyat_Params_ID", (Sevkiyat_Params_ID == null ? 0 : Convert.ToInt32(Sevkiyat_Params_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Sevkiyat_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Sevkiyat_Params>> GetAllAsync()
        {
            try
            {

                var query = "getSevkiyat_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Sevkiyat_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Sevkiyat_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Sevkiyat_Params WHERE Sevkiyat_Params_ID = @Sevkiyat_Params_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Sevkiyat_Params_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Sevkiyat_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Sevkiyat_Params entity)
        {
            try
            {
                var query = "UpdateSevkiyat_ParamsDetails";
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


