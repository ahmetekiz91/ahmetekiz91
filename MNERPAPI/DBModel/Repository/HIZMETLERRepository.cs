
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
    public class HIZMETLERRepository : BaseRepository, IRepository.IHIZMETLERRepository
    {

        public HIZMETLERRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(HIZMETLER entity)
        {

            try
            {
                var query = "AddHIZMETLER";
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

        public async Task<bool> DeleteAsync(object HZMT_ID)
        {
            try
            {
                var query = "DeleteHIZMETLER";

                var parameters = new DynamicParameters();
                parameters.Add("HZMT_ID", (HZMT_ID == null ? 0 : Convert.ToInt32(HZMT_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<HIZMETLER>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<HIZMETLER>> GetAllAsync()
        {
            try
            {

                var query = "getHIZMETLER";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<HIZMETLER>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<HIZMETLER> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM HIZMETLER WHERE HZMT_ID = @HZMT_ID";
                var parameters = new DynamicParameters();
                parameters.Add("HZMT_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<HIZMETLER>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(HIZMETLER entity)
        {
            try
            {
                var query = "UpdateHIZMETLERDetails";
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


