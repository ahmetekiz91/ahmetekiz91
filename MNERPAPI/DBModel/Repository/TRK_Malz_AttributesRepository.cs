
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
    public class TRK_Malz_AttributesRepository : BaseRepository, IRepository.ITRK_Malz_AttributesRepository
    {

        public TRK_Malz_AttributesRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(TRK_Malz_Attributes entity)
        {

            try
            {
                var query = "AddTRK_Malz_Attributes";
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

        public async Task<bool> DeleteAsync(object ID)
        {
            try
            {
                var query = "DeleteTRK_Malz_Attributes";

                var parameters = new DynamicParameters();
                parameters.Add("ID", (ID == null ? 0 : Convert.ToInt32(ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<TRK_Malz_Attributes>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<TRK_Malz_Attributes>> GetAllAsync()
        {
            try
            {

                var query = "getTRK_Malz_Attributes";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<TRK_Malz_Attributes>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<TRK_Malz_Attributes> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM TRK_Malz_Attributes WHERE ID = @ID";
                var parameters = new DynamicParameters();
                parameters.Add("ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<TRK_Malz_Attributes>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(TRK_Malz_Attributes entity)
        {
            try
            {
                var query = "UpdateTRK_Malz_AttributesDetails";
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


