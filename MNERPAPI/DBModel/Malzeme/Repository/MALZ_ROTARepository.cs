
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
    public class MALZ_ROTARepository : BaseRepository, IRepository.IMALZ_ROTARepository
    {

        public MALZ_ROTARepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MALZ_ROTA entity)
        {

            try
            {
                var query = "AddMALZ_ROTA";
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

        public async Task<bool> DeleteAsync(object MALZ_ROT_ID)
        {
            try
            {
                var query = "DeleteMALZ_ROTA";

                var parameters = new DynamicParameters();
                parameters.Add("MALZ_ROT_ID", (MALZ_ROT_ID == null ? 0 : Convert.ToInt32(MALZ_ROT_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MALZ_ROTA>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MALZ_ROTA>> GetAllAsync()
        {
            try
            {

                var query = "getMALZ_ROTA";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MALZ_ROTA>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MALZ_ROTA> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MALZ_ROTA WHERE MALZ_ROT_ID = @MALZ_ROT_ID";
                var parameters = new DynamicParameters();
                parameters.Add("MALZ_ROT_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MALZ_ROTA>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MALZ_ROTA entity)
        {
            try
            {
                var query = "UpdateMALZ_ROTADetails";
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


