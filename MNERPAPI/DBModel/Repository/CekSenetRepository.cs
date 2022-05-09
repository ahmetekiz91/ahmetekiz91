
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
    public class CekSenetRepository : BaseRepository, IRepository.ICekSenetRepository
    {

        public CekSenetRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(CekSenet entity)
        {

            try
            {
                var query = "AddCekSenet";
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

        public async Task<bool> DeleteAsync(object CEKSENET_ID)
        {
            try
            {
                var query = "DeleteCekSenet";

                var parameters = new DynamicParameters();
                parameters.Add("CEKSENET_ID", (CEKSENET_ID == null ? 0 : Convert.ToInt32(CEKSENET_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<CekSenet>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<CekSenet>> GetAllAsync()
        {
            try
            {

                var query = "getCekSenet";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<CekSenet>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<CekSenet> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM CekSenet WHERE CEKSENET_ID = @CEKSENET_ID";
                var parameters = new DynamicParameters();
                parameters.Add("CEKSENET_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<CekSenet>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(CekSenet entity)
        {
            try
            {
                var query = "UpdateCekSenetDetails";
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


