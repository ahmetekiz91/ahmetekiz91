
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
    public class Malz_HareketRepository : BaseRepository, IRepository.IMalz_HareketRepository
    {

        public Malz_HareketRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Malz_Hareket entity)
        {

            try
            {
                var query = "AddMalz_Hareket";
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

        public async Task<bool> DeleteAsync(object Malz_Har_ID)
        {
            try
            {
                var query = "DeleteMalz_Hareket";

                var parameters = new DynamicParameters();
                parameters.Add("Malz_Har_ID", (Malz_Har_ID == null ? 0 : Convert.ToInt32(Malz_Har_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Malz_Hareket>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Malz_Hareket>> GetAllAsync()
        {
            try
            {

                var query = "getMalz_Hareket";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Malz_Hareket>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Malz_Hareket> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Malz_Hareket WHERE Malz_Har_ID = @Malz_Har_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Malz_Har_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Malz_Hareket>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Malz_Hareket entity)
        {
            try
            {
                var query = "UpdateMalz_HareketDetails";
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


