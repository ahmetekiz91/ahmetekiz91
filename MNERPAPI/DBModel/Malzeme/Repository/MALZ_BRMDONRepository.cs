
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
    public class MALZ_BRMDONRepository : BaseRepository, IRepository.IMALZ_BRMDONRepository
    {

        public MALZ_BRMDONRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MALZ_BRMDON entity)
        {

            try
            {
                var query = "AddMALZ_BRMDON";
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

        public async Task<bool> DeleteAsync(object MALZ_BRMDON_ID)
        {
            try
            {
                var query = "DeleteMALZ_BRMDON";

                var parameters = new DynamicParameters();
                parameters.Add("MALZ_BRMDON_ID", (MALZ_BRMDON_ID == null ? 0 : Convert.ToInt32(MALZ_BRMDON_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MALZ_BRMDON>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MALZ_BRMDON>> GetAllAsync()
        {
            try
            {

                var query = "getMALZ_BRMDON";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MALZ_BRMDON>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MALZ_BRMDON> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MALZ_BRMDON WHERE MALZ_BRMDON_ID = @MALZ_BRMDON_ID";
                var parameters = new DynamicParameters();
                parameters.Add("MALZ_BRMDON_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MALZ_BRMDON>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MALZ_BRMDON entity)
        {
            try
            {
                var query = "UpdateMALZ_BRMDONDetails";
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


