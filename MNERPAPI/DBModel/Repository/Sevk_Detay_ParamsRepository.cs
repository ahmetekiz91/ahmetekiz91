
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
    public class Sevk_Detay_ParamsRepository : BaseRepository, IRepository.ISevk_Detay_ParamsRepository
    {

        public Sevk_Detay_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Sevk_Detay_Params entity)
        {

            try
            {
                var query = "AddSevk_Detay_Params";
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

        public async Task<bool> DeleteAsync(object Sevk_Detay_Params_ID)
        {
            try
            {
                var query = "DeleteSevk_Detay_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Sevk_Detay_Params_ID", (Sevk_Detay_Params_ID == null ? 0 : Convert.ToInt32(Sevk_Detay_Params_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Sevk_Detay_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Sevk_Detay_Params>> GetAllAsync()
        {
            try
            {

                var query = "getSevk_Detay_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Sevk_Detay_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Sevk_Detay_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Sevk_Detay_Params WHERE Sevk_Detay_Params_ID = @Sevk_Detay_Params_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Sevk_Detay_Params_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Sevk_Detay_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Sevk_Detay_Params entity)
        {
            try
            {
                var query = "UpdateSevk_Detay_ParamsDetails";
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


