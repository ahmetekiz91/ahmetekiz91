
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
    public class MarkalarRepository : BaseRepository, IRepository.IMarkalarRepository
    {

        public MarkalarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Markalar entity)
        {

            try
            {
                var query = "AddMarkalar";
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

        public async Task<bool> DeleteAsync(object Marka_ID)
        {
            try
            {
                var query = "DeleteMarkalar";

                var parameters = new DynamicParameters();
                parameters.Add("Marka_ID", (Marka_ID == null ? 0 : Convert.ToInt32(Marka_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Markalar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Markalar>> GetAllAsync()
        {
            try
            {

                var query = "getMarkalar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Markalar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Markalar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Markalar WHERE Marka_ID = @Marka_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Marka_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Markalar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Markalar entity)
        {
            try
            {
                var query = "UpdateMarkalarDetails";
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


