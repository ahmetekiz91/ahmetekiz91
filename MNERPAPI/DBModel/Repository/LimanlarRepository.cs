
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
    public class LimanlarRepository : BaseRepository, IRepository.ILimanlarRepository
    {

        public LimanlarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Limanlar entity)
        {

            try
            {
                var query = "AddLimanlar";
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

        public async Task<bool> DeleteAsync(object Liman_ID)
        {
            try
            {
                var query = "DeleteLimanlar";

                var parameters = new DynamicParameters();
                parameters.Add("Liman_ID", (Liman_ID == null ? 0 : Convert.ToInt32(Liman_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Limanlar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Limanlar>> GetAllAsync()
        {
            try
            {

                var query = "getLimanlar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Limanlar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Limanlar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Limanlar WHERE Liman_ID = @Liman_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Liman_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Limanlar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Limanlar entity)
        {
            try
            {
                var query = "UpdateLimanlarDetails";
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


