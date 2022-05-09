
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
    public class MALZ_ROTA_TUKETIMRepository : BaseRepository, IRepository.IMALZ_ROTA_TUKETIMRepository
    {

        public MALZ_ROTA_TUKETIMRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MALZ_ROTA_TUKETIM entity)
        {

            try
            {
                var query = "AddMALZ_ROTA_TUKETIM";
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

        public async Task<bool> DeleteAsync(object MRU_TUK_ID)
        {
            try
            {
                var query = "DeleteMALZ_ROTA_TUKETIM";

                var parameters = new DynamicParameters();
                parameters.Add("MRU_TUK_ID", (MRU_TUK_ID == null ? 0 : Convert.ToInt32(MRU_TUK_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MALZ_ROTA_TUKETIM>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MALZ_ROTA_TUKETIM>> GetAllAsync()
        {
            try
            {

                var query = "getMALZ_ROTA_TUKETIM";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MALZ_ROTA_TUKETIM>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MALZ_ROTA_TUKETIM> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MALZ_ROTA_TUKETIM WHERE MRU_TUK_ID = @MRU_TUK_ID";
                var parameters = new DynamicParameters();
                parameters.Add("MRU_TUK_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MALZ_ROTA_TUKETIM>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MALZ_ROTA_TUKETIM entity)
        {
            try
            {
                var query = "UpdateMALZ_ROTA_TUKETIMDetails";
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


