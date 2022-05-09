
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
    public class MCategoryRepository : BaseRepository, IRepository.IMCategoryRepository
    {

        public MCategoryRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MCategory entity)
        {

            try
            {
                var query = "AddMCategory";
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

        public async Task<bool> DeleteAsync(object CAT_ID)
        {
            try
            {
                var query = "DeleteMCategory";

                var parameters = new DynamicParameters();
                parameters.Add("CAT_ID", (CAT_ID == null ? 0 : Convert.ToInt32(CAT_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MCategory>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MCategory>> GetAllAsync()
        {
            try
            {

                var query = "getMCategory";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MCategory>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MCategory> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MCategory WHERE CAT_ID = @CAT_ID";
                var parameters = new DynamicParameters();
                parameters.Add("CAT_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MCategory>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MCategory entity)
        {
            try
            {
                var query = "UpdateMCategoryDetails";
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


