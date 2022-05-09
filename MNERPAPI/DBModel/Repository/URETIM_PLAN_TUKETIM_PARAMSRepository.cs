
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
    public class URETIM_PLAN_TUKETIM_PARAMSRepository : BaseRepository, IRepository.IURETIM_PLAN_TUKETIM_PARAMSRepository
    {

        public URETIM_PLAN_TUKETIM_PARAMSRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(URETIM_PLAN_TUKETIM_PARAMS entity)
        {

            try
            {
                var query = "AddURETIM_PLAN_TUKETIM_PARAMS";
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

        public async Task<bool> DeleteAsync(object URET_PLAN_TUK_PAR_ID)
        {
            try
            {
                var query = "DeleteURETIM_PLAN_TUKETIM_PARAMS";

                var parameters = new DynamicParameters();
                parameters.Add("URET_PLAN_TUK_PAR_ID", (URET_PLAN_TUK_PAR_ID == null ? 0 : Convert.ToInt32(URET_PLAN_TUK_PAR_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<URETIM_PLAN_TUKETIM_PARAMS>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<URETIM_PLAN_TUKETIM_PARAMS>> GetAllAsync()
        {
            try
            {

                var query = "getURETIM_PLAN_TUKETIM_PARAMS";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<URETIM_PLAN_TUKETIM_PARAMS>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<URETIM_PLAN_TUKETIM_PARAMS> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM URETIM_PLAN_TUKETIM_PARAMS WHERE URET_PLAN_TUK_PAR_ID = @URET_PLAN_TUK_PAR_ID";
                var parameters = new DynamicParameters();
                parameters.Add("URET_PLAN_TUK_PAR_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<URETIM_PLAN_TUKETIM_PARAMS>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(URETIM_PLAN_TUKETIM_PARAMS entity)
        {
            try
            {
                var query = "UpdateURETIM_PLAN_TUKETIM_PARAMSDetails";
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


