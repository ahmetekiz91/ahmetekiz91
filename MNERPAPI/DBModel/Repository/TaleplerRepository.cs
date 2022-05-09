
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
    public class TaleplerRepository : BaseRepository, IRepository.ITaleplerRepository
    {

        public TaleplerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Talepler entity)
        {

            try
            {
                var query = "AddTalepler";
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

        public async Task<bool> DeleteAsync(object Talep_ID)
        {
            try
            {
                var query = "DeleteTalepler";

                var parameters = new DynamicParameters();
                parameters.Add("Talep_ID", (Talep_ID == null ? 0 : Convert.ToInt32(Talep_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Talepler>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Talepler>> GetAllAsync()
        {
            try
            {

                var query = "getTalepler";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Talepler>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Talepler> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Talepler WHERE Talep_ID = @Talep_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Talep_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Talepler>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Talepler entity)
        {
            try
            {
                var query = "UpdateTaleplerDetails";
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


