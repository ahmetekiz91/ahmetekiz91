
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
    public class HIZMET_BIRIMLERRepository : BaseRepository, IRepository.IHIZMET_BIRIMLERRepository
    {

        public HIZMET_BIRIMLERRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(HIZMET_BIRIMLER entity)
        {

            try
            {
                var query = "AddHIZMET_BIRIMLER";
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

        public async Task<bool> DeleteAsync(object HZM_BMR_ID)
        {
            try
            {
                var query = "DeleteHIZMET_BIRIMLER";

                var parameters = new DynamicParameters();
                parameters.Add("HZM_BMR_ID", (HZM_BMR_ID == null ? 0 : Convert.ToInt32(HZM_BMR_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<HIZMET_BIRIMLER>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<HIZMET_BIRIMLER>> GetAllAsync()
        {
            try
            {

                var query = "getHIZMET_BIRIMLER";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<HIZMET_BIRIMLER>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<HIZMET_BIRIMLER> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM HIZMET_BIRIMLER WHERE HZM_BMR_ID = @HZM_BMR_ID";
                var parameters = new DynamicParameters();
                parameters.Add("HZM_BMR_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<HIZMET_BIRIMLER>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(HIZMET_BIRIMLER entity)
        {
            try
            {
                var query = "UpdateHIZMET_BIRIMLERDetails";
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


