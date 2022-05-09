
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
    public class BORDRO_BORCLU_KISIRepository : BaseRepository, IRepository.IBORDRO_BORCLU_KISIRepository
    {

        public BORDRO_BORCLU_KISIRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(BORDRO_BORCLU_KISI entity)
        {

            try
            {
                var query = "AddBORDRO_BORCLU_KISI";
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

        public async Task<bool> DeleteAsync(object SEN_BORC_ID)
        {
            try
            {
                var query = "DeleteBORDRO_BORCLU_KISI";

                var parameters = new DynamicParameters();
                parameters.Add("SEN_BORC_ID", (SEN_BORC_ID == null ? 0 : Convert.ToInt32(SEN_BORC_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<BORDRO_BORCLU_KISI>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<BORDRO_BORCLU_KISI>> GetAllAsync()
        {
            try
            {

                var query = "getBORDRO_BORCLU_KISI";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<BORDRO_BORCLU_KISI>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BORDRO_BORCLU_KISI> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM BORDRO_BORCLU_KISI WHERE SEN_BORC_ID = @SEN_BORC_ID";
                var parameters = new DynamicParameters();
                parameters.Add("SEN_BORC_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<BORDRO_BORCLU_KISI>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(BORDRO_BORCLU_KISI entity)
        {
            try
            {
                var query = "UpdateBORDRO_BORCLU_KISIDetails";
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


