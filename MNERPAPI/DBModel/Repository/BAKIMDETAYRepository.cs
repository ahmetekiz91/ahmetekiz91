
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
    public class BAKIMDETAYRepository : BaseRepository, IRepository.IBAKIMDETAYRepository
    {

        public BAKIMDETAYRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(BAKIMDETAY entity)
        {

            try
            {
                var query = "AddBAKIMDETAY";
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

        public async Task<bool> DeleteAsync(object BAKD_ID)
        {
            try
            {
                var query = "DeleteBAKIMDETAY";

                var parameters = new DynamicParameters();
                parameters.Add("BAKD_ID", (BAKD_ID == null ? 0 : Convert.ToInt32(BAKD_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<BAKIMDETAY>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<BAKIMDETAY>> GetAllAsync()
        {
            try
            {

                var query = "getBAKIMDETAY";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<BAKIMDETAY>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BAKIMDETAY> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM BAKIMDETAY WHERE BAKD_ID = @BAKD_ID";
                var parameters = new DynamicParameters();
                parameters.Add("BAKD_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<BAKIMDETAY>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(BAKIMDETAY entity)
        {
            try
            {
                var query = "UpdateBAKIMDETAYDetails";
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


