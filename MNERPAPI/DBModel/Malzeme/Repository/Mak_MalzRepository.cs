
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
    public class Mak_MalzRepository : BaseRepository, IRepository.IMak_MalzRepository
    {

        public Mak_MalzRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Mak_Malz entity)
        {

            try
            {
                var query = "AddMak_Malz";
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

        public async Task<bool> DeleteAsync(object Malz_Mak_ID)
        {
            try
            {
                var query = "DeleteMak_Malz";

                var parameters = new DynamicParameters();
                parameters.Add("Malz_Mak_ID", (Malz_Mak_ID == null ? 0 : Convert.ToInt32(Malz_Mak_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Mak_Malz>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Mak_Malz>> GetAllAsync()
        {
            try
            {

                var query = "getMak_Malz";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Mak_Malz>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Mak_Malz> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Mak_Malz WHERE Malz_Mak_ID = @Malz_Mak_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Malz_Mak_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Mak_Malz>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Mak_Malz entity)
        {
            try
            {
                var query = "UpdateMak_MalzDetails";
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


