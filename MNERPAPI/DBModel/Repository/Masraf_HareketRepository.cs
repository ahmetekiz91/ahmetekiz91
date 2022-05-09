
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
    public class Masraf_HareketRepository : BaseRepository, IRepository.IMasraf_HareketRepository
    {

        public Masraf_HareketRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Masraf_Hareket entity)
        {

            try
            {
                var query = "AddMasraf_Hareket";
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

        public async Task<bool> DeleteAsync(object Masraf_Har_ID)
        {
            try
            {
                var query = "DeleteMasraf_Hareket";

                var parameters = new DynamicParameters();
                parameters.Add("Masraf_Har_ID", (Masraf_Har_ID == null ? 0 : Convert.ToInt32(Masraf_Har_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Masraf_Hareket>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Masraf_Hareket>> GetAllAsync()
        {
            try
            {

                var query = "getMasraf_Hareket";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Masraf_Hareket>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Masraf_Hareket> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Masraf_Hareket WHERE Masraf_Har_ID = @Masraf_Har_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Masraf_Har_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Masraf_Hareket>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Masraf_Hareket entity)
        {
            try
            {
                var query = "UpdateMasraf_HareketDetails";
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


