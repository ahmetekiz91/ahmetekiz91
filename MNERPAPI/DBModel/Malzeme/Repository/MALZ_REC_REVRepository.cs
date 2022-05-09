
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
    public class MALZ_REC_REVRepository : BaseRepository, IRepository.IMALZ_REC_REVRepository
    {

        public MALZ_REC_REVRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MALZ_REC_REV entity)
        {

            try
            {
                var query = "AddMALZ_REC_REV";
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

        public async Task<bool> DeleteAsync(object REV_ID)
        {
            try
            {
                var query = "DeleteMALZ_REC_REV";

                var parameters = new DynamicParameters();
                parameters.Add("REV_ID", (REV_ID == null ? 0 : Convert.ToInt32(REV_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MALZ_REC_REV>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MALZ_REC_REV>> GetAllAsync()
        {
            try
            {

                var query = "getMALZ_REC_REV";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MALZ_REC_REV>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MALZ_REC_REV> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MALZ_REC_REV WHERE REV_ID = @REV_ID";
                var parameters = new DynamicParameters();
                parameters.Add("REV_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MALZ_REC_REV>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MALZ_REC_REV entity)
        {
            try
            {
                var query = "UpdateMALZ_REC_REVDetails";
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


