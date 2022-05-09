
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
    public class Sip_KalemRepository : BaseRepository, IRepository.ISip_KalemRepository
    {

        public Sip_KalemRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Sip_Kalem entity)
        {

            try
            {
                var query = "AddSip_Kalem";
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

        public async Task<bool> DeleteAsync(object Sip_Kal_ID)
        {
            try
            {
                var query = "DeleteSip_Kalem";

                var parameters = new DynamicParameters();
                parameters.Add("Sip_Kal_ID", (Sip_Kal_ID == null ? 0 : Convert.ToInt32(Sip_Kal_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Sip_Kalem>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Sip_Kalem>> GetAllAsync()
        {
            try
            {

                var query = "getSip_Kalem";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Sip_Kalem>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Sip_Kalem> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Sip_Kalem WHERE Sip_Kal_ID = @Sip_Kal_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Sip_Kal_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Sip_Kalem>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Sip_Kalem entity)
        {
            try
            {
                var query = "UpdateSip_KalemDetails";
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


