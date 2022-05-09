
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
    public class MasraflarRepository : BaseRepository, IRepository.IMasraflarRepository
    {

        public MasraflarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Masraflar entity)
        {

            try
            {
                var query = "AddMasraflar";
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

        public async Task<bool> DeleteAsync(object Masraf_ID)
        {
            try
            {
                var query = "DeleteMasraflar";

                var parameters = new DynamicParameters();
                parameters.Add("Masraf_ID", (Masraf_ID == null ? 0 : Convert.ToInt32(Masraf_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Masraflar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Masraflar>> GetAllAsync()
        {
            try
            {

                var query = "getMasraflar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Masraflar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Masraflar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Masraflar WHERE Masraf_ID = @Masraf_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Masraf_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Masraflar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Masraflar entity)
        {
            try
            {
                var query = "UpdateMasraflarDetails";
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


