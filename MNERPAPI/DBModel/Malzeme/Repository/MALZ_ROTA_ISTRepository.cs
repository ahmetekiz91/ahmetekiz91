
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
    public class MALZ_ROTA_ISTRepository : BaseRepository, IRepository.IMALZ_ROTA_ISTRepository
    {

        public MALZ_ROTA_ISTRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MALZ_ROTA_IST entity)
        {

            try
            {
                var query = "AddMALZ_ROTA_IST";
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

        public async Task<bool> DeleteAsync(object MALZ_ROT_IST_ID)
        {
            try
            {
                var query = "DeleteMALZ_ROTA_IST";

                var parameters = new DynamicParameters();
                parameters.Add("MALZ_ROT_IST_ID", (MALZ_ROT_IST_ID == null ? 0 : Convert.ToInt32(MALZ_ROT_IST_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MALZ_ROTA_IST>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MALZ_ROTA_IST>> GetAllAsync()
        {
            try
            {

                var query = "getMALZ_ROTA_IST";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MALZ_ROTA_IST>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MALZ_ROTA_IST> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MALZ_ROTA_IST WHERE MALZ_ROT_IST_ID = @MALZ_ROT_IST_ID";
                var parameters = new DynamicParameters();
                parameters.Add("MALZ_ROT_IST_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MALZ_ROTA_IST>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MALZ_ROTA_IST entity)
        {
            try
            {
                var query = "UpdateMALZ_ROTA_ISTDetails";
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


