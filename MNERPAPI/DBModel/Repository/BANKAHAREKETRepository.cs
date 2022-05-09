
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
    public class BANKAHAREKETRepository : BaseRepository, IRepository.IBANKAHAREKETRepository
    {

        public BANKAHAREKETRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(BANKAHAREKET entity)
        {

            try
            {
                var query = "AddBANKAHAREKET";
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

        public async Task<bool> DeleteAsync(object BANKA_HAR_ID)
        {
            try
            {
                var query = "DeleteBANKAHAREKET";

                var parameters = new DynamicParameters();
                parameters.Add("BANKA_HAR_ID", (BANKA_HAR_ID == null ? 0 : Convert.ToInt32(BANKA_HAR_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<BANKAHAREKET>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<BANKAHAREKET>> GetAllAsync()
        {
            try
            {

                var query = "getBANKAHAREKET";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<BANKAHAREKET>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BANKAHAREKET> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM BANKAHAREKET WHERE BANKA_HAR_ID = @BANKA_HAR_ID";
                var parameters = new DynamicParameters();
                parameters.Add("BANKA_HAR_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<BANKAHAREKET>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(BANKAHAREKET entity)
        {
            try
            {
                var query = "UpdateBANKAHAREKETDetails";
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


