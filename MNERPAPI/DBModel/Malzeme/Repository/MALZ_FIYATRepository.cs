
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
    public class MALZ_FIYATRepository : BaseRepository, IRepository.IMALZ_FIYATRepository
    {

        public MALZ_FIYATRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MALZ_FIYAT entity)
        {

            try
            {
                var query = "AddMALZ_FIYAT";
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

        public async Task<bool> DeleteAsync(object REFID)
        {
            try
            {
                var query = "DeleteMALZ_FIYAT";

                var parameters = new DynamicParameters();
                parameters.Add("REFID", (REFID == null ? 0 : Convert.ToInt32(REFID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MALZ_FIYAT>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MALZ_FIYAT>> GetAllAsync()
        {
            try
            {

                var query = "getMALZ_FIYAT";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MALZ_FIYAT>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MALZ_FIYAT> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MALZ_FIYAT WHERE REFID = @REFID";
                var parameters = new DynamicParameters();
                parameters.Add("REFID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MALZ_FIYAT>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MALZ_FIYAT entity)
        {
            try
            {
                var query = "UpdateMALZ_FIYATDetails";
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


