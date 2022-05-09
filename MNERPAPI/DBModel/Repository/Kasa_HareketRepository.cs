
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
    public class Kasa_HareketRepository : BaseRepository, IRepository.IKasa_HareketRepository
    {

        public Kasa_HareketRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Kasa_Hareket entity)
        {

            try
            {
                var query = "AddKasa_Hareket";
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

        public async Task<bool> DeleteAsync(object Kasa_Har_ID)
        {
            try
            {
                var query = "DeleteKasa_Hareket";

                var parameters = new DynamicParameters();
                parameters.Add("Kasa_Har_ID", (Kasa_Har_ID == null ? 0 : Convert.ToInt32(Kasa_Har_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Kasa_Hareket>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Kasa_Hareket>> GetAllAsync()
        {
            try
            {

                var query = "getKasa_Hareket";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Kasa_Hareket>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Kasa_Hareket> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Kasa_Hareket WHERE Kasa_Har_ID = @Kasa_Har_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Kasa_Har_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Kasa_Hareket>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Kasa_Hareket entity)
        {
            try
            {
                var query = "UpdateKasa_HareketDetails";
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


