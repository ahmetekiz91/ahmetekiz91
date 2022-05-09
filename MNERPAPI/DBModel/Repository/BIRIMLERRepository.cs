
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
    public class BIRIMLERRepository : BaseRepository, IRepository.IBIRIMLERRepository
    {

        public BIRIMLERRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(BIRIMLER entity)
        {

            try
            {
                var query = "AddBIRIMLER";
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

        public async Task<bool> DeleteAsync(object BRM_ID)
        {
            try
            {
                var query = "DeleteBIRIMLER";

                var parameters = new DynamicParameters();
                parameters.Add("BRM_ID", (BRM_ID == null ? 0 : Convert.ToInt32(BRM_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<BIRIMLER>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<BIRIMLER>> GetAllAsync()
        {
            try
            {

                var query = "getBIRIMLER";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<BIRIMLER>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BIRIMLER> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM BIRIMLER WHERE BRM_ID=@BRM_ID";
                var parameters = new DynamicParameters();
                parameters.Add("BRM_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<BIRIMLER>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(BIRIMLER entity)
        {
            try
            {
                var query = "UpdateBIRIMLERDetails";
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


