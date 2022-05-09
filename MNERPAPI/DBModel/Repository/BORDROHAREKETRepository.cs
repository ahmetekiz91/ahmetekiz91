
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
    public class BORDROHAREKETRepository : BaseRepository, IRepository.IBORDROHAREKETRepository
    {

        public BORDROHAREKETRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(BORDROHAREKET entity)
        {

            try
            {
                var query = "AddBORDROHAREKET";
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

        public async Task<bool> DeleteAsync(object BORD_HAR_ID)
        {
            try
            {
                var query = "DeleteBORDROHAREKET";

                var parameters = new DynamicParameters();
                parameters.Add("BORD_HAR_ID", (BORD_HAR_ID == null ? 0 : Convert.ToInt32(BORD_HAR_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<BORDROHAREKET>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<BORDROHAREKET>> GetAllAsync()
        {
            try
            {

                var query = "getBORDROHAREKET";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<BORDROHAREKET>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BORDROHAREKET> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM BORDROHAREKET WHERE BORD_HAR_ID = @BORD_HAR_ID";
                var parameters = new DynamicParameters();
                parameters.Add("BORD_HAR_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<BORDROHAREKET>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(BORDROHAREKET entity)
        {
            try
            {
                var query = "UpdateBORDROHAREKETDetails";
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


