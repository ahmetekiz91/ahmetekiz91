
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
    public class MALZ_ROTA_URETIMRepository : BaseRepository, IRepository.IMALZ_ROTA_URETIMRepository
    {

        public MALZ_ROTA_URETIMRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MALZ_ROTA_URETIM entity)
        {

            try
            {
                var query = "AddMALZ_ROTA_URETIM";
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

        public async Task<bool> DeleteAsync(object MAL_ROT_URTM_ID)
        {
            try
            {
                var query = "DeleteMALZ_ROTA_URETIM";

                var parameters = new DynamicParameters();
                parameters.Add("MAL_ROT_URTM_ID", (MAL_ROT_URTM_ID == null ? 0 : Convert.ToInt32(MAL_ROT_URTM_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MALZ_ROTA_URETIM>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MALZ_ROTA_URETIM>> GetAllAsync()
        {
            try
            {

                var query = "getMALZ_ROTA_URETIM";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MALZ_ROTA_URETIM>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MALZ_ROTA_URETIM> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MALZ_ROTA_URETIM WHERE MAL_ROT_URTM_ID = @MAL_ROT_URTM_ID";
                var parameters = new DynamicParameters();
                parameters.Add("MAL_ROT_URTM_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MALZ_ROTA_URETIM>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MALZ_ROTA_URETIM entity)
        {
            try
            {
                var query = "UpdateMALZ_ROTA_URETIMDetails";
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


