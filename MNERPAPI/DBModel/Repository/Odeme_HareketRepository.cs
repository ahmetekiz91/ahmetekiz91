
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
    public class Odeme_HareketRepository : BaseRepository, IRepository.IOdeme_HareketRepository
    {

        public Odeme_HareketRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Odeme_Hareket entity)
        {

            try
            {
                var query = "AddOdeme_Hareket";
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

        public async Task<bool> DeleteAsync(object Odeme_Sekli_Har_ID)
        {
            try
            {
                var query = "DeleteOdeme_Hareket";

                var parameters = new DynamicParameters();
                parameters.Add("Odeme_Sekli_Har_ID", (Odeme_Sekli_Har_ID == null ? 0 : Convert.ToInt32(Odeme_Sekli_Har_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Odeme_Hareket>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Odeme_Hareket>> GetAllAsync()
        {
            try
            {

                var query = "getOdeme_Hareket";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Odeme_Hareket>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Odeme_Hareket> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Odeme_Hareket WHERE Odeme_Sekli_Har_ID = @Odeme_Sekli_Har_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Odeme_Sekli_Har_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Odeme_Hareket>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Odeme_Hareket entity)
        {
            try
            {
                var query = "UpdateOdeme_HareketDetails";
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


