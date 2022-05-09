
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
    public class UlkelerRepository : BaseRepository, IRepository.IUlkelerRepository
    {

        public UlkelerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Ulkeler entity)
        {

            try
            {
                var query = "AddUlkeler";
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

        public async Task<bool> DeleteAsync(object Ulke_ID)
        {
            try
            {
                var query = "DeleteUlkeler";

                var parameters = new DynamicParameters();
                parameters.Add("Ulke_ID", (Ulke_ID == null ? 0 : Convert.ToInt32(Ulke_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Ulkeler>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Ulkeler>> GetAllAsync()
        {
            try
            {

                var query = "getUlkeler";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Ulkeler>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Ulkeler> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Ulkeler WHERE Ulke_ID = @Ulke_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Ulke_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Ulkeler>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Ulkeler entity)
        {
            try
            {
                var query = "UpdateUlkelerDetails";
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


