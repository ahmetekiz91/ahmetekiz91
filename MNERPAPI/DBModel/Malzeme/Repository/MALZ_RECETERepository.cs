
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
    public class MALZ_RECETERepository : BaseRepository, IRepository.IMALZ_RECETERepository
    {

        public MALZ_RECETERepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MALZ_RECETE entity)
        {

            try
            {
                var query = "AddMALZ_RECETE";
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

        public async Task<bool> DeleteAsync(object REC_ID)
        {
            try
            {
                var query = "DeleteMALZ_RECETE";

                var parameters = new DynamicParameters();
                parameters.Add("REC_ID", (REC_ID == null ? 0 : Convert.ToInt32(REC_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MALZ_RECETE>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MALZ_RECETE>> GetAllAsync()
        {
            try
            {

                var query = "getMALZ_RECETE";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MALZ_RECETE>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MALZ_RECETE> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MALZ_RECETE WHERE REC_ID = @REC_ID";
                var parameters = new DynamicParameters();
                parameters.Add("REC_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MALZ_RECETE>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MALZ_RECETE entity)
        {
            try
            {
                var query = "UpdateMALZ_RECETEDetails";
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


