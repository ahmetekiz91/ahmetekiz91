
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
    public class MALZ_BIRIMRepository : BaseRepository, IRepository.IMALZ_BIRIMRepository
    {

        public MALZ_BIRIMRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MALZ_BIRIM entity)
        {

            try
            {
                var query = "AddMALZ_BIRIM";
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

        public async Task<bool> DeleteAsync(object MALZ_BRM_ID)
        {
            try
            {
                var query = "DeleteMALZ_BIRIM";

                var parameters = new DynamicParameters();
                parameters.Add("MALZ_BRM_ID", (MALZ_BRM_ID == null ? 0 : Convert.ToInt32(MALZ_BRM_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MALZ_BIRIM>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MALZ_BIRIM>> GetAllAsync()
        {
            try
            {

                var query = "getMALZ_BIRIM";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MALZ_BIRIM>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MALZ_BIRIM> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MALZ_BIRIM WHERE MALZ_BRM_ID = @MALZ_BRM_ID";
                var parameters = new DynamicParameters();
                parameters.Add("MALZ_BRM_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MALZ_BIRIM>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MALZ_BIRIM entity)
        {
            try
            {
                var query = "UpdateMALZ_BIRIMDetails";
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


