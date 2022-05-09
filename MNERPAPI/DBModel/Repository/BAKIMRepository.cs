
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
    public class BAKIMRepository : BaseRepository, IRepository.IBAKIMRepository
    {

        public BAKIMRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(BAKIM entity)
        {

            try
            {
                var query = "AddBAKIM";
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

        public async Task<bool> DeleteAsync(object BAK_ID)
        {
            try
            {
                var query = "DeleteBAKIM";

                var parameters = new DynamicParameters();
                parameters.Add("BAK_ID", (BAK_ID == null ? 0 : Convert.ToInt32(BAK_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<BAKIM>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<BAKIM>> GetAllAsync()
        {
            try
            {

                var query = "getBAKIM";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<BAKIM>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BAKIM> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM BAKIM WHERE BAK_ID = @BAK_ID";
                var parameters = new DynamicParameters();
                parameters.Add("BAK_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<BAKIM>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(BAKIM entity)
        {
            try
            {
                var query = "UpdateBAKIMDetails";
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


