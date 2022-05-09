
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
    public class HatlarRepository : BaseRepository, IRepository.IHatlarRepository
    {

        public HatlarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Hatlar entity)
        {

            try
            {
                var query = "AddHatlar";
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

        public async Task<bool> DeleteAsync(object Hat_ID)
        {
            try
            {
                var query = "DeleteHatlar";

                var parameters = new DynamicParameters();
                parameters.Add("Hat_ID", (Hat_ID == null ? 0 : Convert.ToInt32(Hat_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Hatlar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Hatlar>> GetAllAsync()
        {
            try
            {

                var query = "getHatlar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Hatlar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Hatlar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Hatlar WHERE Hat_ID = @Hat_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Hat_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Hatlar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Hatlar entity)
        {
            try
            {
                var query = "UpdateHatlarDetails";
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


