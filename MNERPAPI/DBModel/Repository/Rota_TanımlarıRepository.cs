
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
    public class Rota_TanımlarıRepository : BaseRepository, IRepository.IRota_TanımlarıRepository
    {

        public Rota_TanımlarıRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Rota_Tanımları entity)
        {

            try
            {
                var query = "AddRota_Tanımları";
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

        public async Task<bool> DeleteAsync(object Rota_Tanim_ID)
        {
            try
            {
                var query = "DeleteRota_Tanımları";

                var parameters = new DynamicParameters();
                parameters.Add("Rota_Tanim_ID", (Rota_Tanim_ID == null ? 0 : Convert.ToInt32(Rota_Tanim_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Rota_Tanımları>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Rota_Tanımları>> GetAllAsync()
        {
            try
            {

                var query = "getRota_Tanımları";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Rota_Tanımları>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Rota_Tanımları> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Rota_Tanımları WHERE Rota_Tanim_ID = @Rota_Tanim_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Rota_Tanim_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Rota_Tanımları>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Rota_Tanımları entity)
        {
            try
            {
                var query = "UpdateRota_TanımlarıDetails";
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


