
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
    public class BANKAISLEMTURLERIRepository : BaseRepository, IRepository.IBANKAISLEMTURLERIRepository
    {

        public BANKAISLEMTURLERIRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(BANKAISLEMTURLERI entity)
        {

            try
            {
                var query = "AddBANKAISLEMTURLERI";
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

        public async Task<bool> DeleteAsync(object BNK_ISL_ID)
        {
            try
            {
                var query = "DeleteBANKAISLEMTURLERI";

                var parameters = new DynamicParameters();
                parameters.Add("BNK_ISL_ID", (BNK_ISL_ID == null ? 0 : Convert.ToInt32(BNK_ISL_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<BANKAISLEMTURLERI>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<BANKAISLEMTURLERI>> GetAllAsync()
        {
            try
            {

                var query = "getBANKAISLEMTURLERI";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<BANKAISLEMTURLERI>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BANKAISLEMTURLERI> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM BANKAISLEMTURLERI WHERE BNK_ISL_ID = @BNK_ISL_ID";
                var parameters = new DynamicParameters();
                parameters.Add("BNK_ISL_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<BANKAISLEMTURLERI>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(BANKAISLEMTURLERI entity)
        {
            try
            {
                var query = "UpdateBANKAISLEMTURLERIDetails";
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


