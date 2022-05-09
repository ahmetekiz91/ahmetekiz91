
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
    public class MALZ_ROTA_URETILENRepository : BaseRepository, IRepository.IMALZ_ROTA_URETILENRepository
    {

        public MALZ_ROTA_URETILENRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MALZ_ROTA_URETILEN entity)
        {

            try
            {
                var query = "AddMALZ_ROTA_URETILEN";
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

        public async Task<bool> DeleteAsync(object URE_ID)
        {
            try
            {
                var query = "DeleteMALZ_ROTA_URETILEN";

                var parameters = new DynamicParameters();
                parameters.Add("URE_ID", (URE_ID == null ? 0 : Convert.ToInt32(URE_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MALZ_ROTA_URETILEN>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MALZ_ROTA_URETILEN>> GetAllAsync()
        {
            try
            {

                var query = "getMALZ_ROTA_URETILEN";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MALZ_ROTA_URETILEN>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MALZ_ROTA_URETILEN> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MALZ_ROTA_URETILEN WHERE URE_ID = @URE_ID";
                var parameters = new DynamicParameters();
                parameters.Add("URE_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MALZ_ROTA_URETILEN>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MALZ_ROTA_URETILEN entity)
        {
            try
            {
                var query = "UpdateMALZ_ROTA_URETILENDetails";
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


