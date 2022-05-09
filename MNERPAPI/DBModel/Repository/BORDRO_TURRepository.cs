
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
    public class BORDRO_TURRepository : BaseRepository, IRepository.IBORDRO_TURRepository
    {

        public BORDRO_TURRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(BORDRO_TUR entity)
        {

            try
            {
                var query = "AddBORDRO_TUR";
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

        public async Task<bool> DeleteAsync(object BORD_TUR_ID)
        {
            try
            {
                var query = "DeleteBORDRO_TUR";

                var parameters = new DynamicParameters();
                parameters.Add("BORD_TUR_ID", (BORD_TUR_ID == null ? 0 : Convert.ToInt32(BORD_TUR_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<BORDRO_TUR>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<BORDRO_TUR>> GetAllAsync()
        {
            try
            {

                var query = "getBORDRO_TUR";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<BORDRO_TUR>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BORDRO_TUR> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM BORDRO_TUR WHERE BORD_TUR_ID = @BORD_TUR_ID";
                var parameters = new DynamicParameters();
                parameters.Add("BORD_TUR_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<BORDRO_TUR>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(BORDRO_TUR entity)
        {
            try
            {
                var query = "UpdateBORDRO_TURDetails";
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


