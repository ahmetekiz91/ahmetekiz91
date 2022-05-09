
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
    public class BORDRORepository : BaseRepository, IRepository.IBORDRORepository
    {

        public BORDRORepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(BORDRO entity)
        {

            try
            {
                var query = "AddBORDRO";
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

        public async Task<bool> DeleteAsync(object BORD_ID)
        {
            try
            {
                var query = "DeleteBORDRO";

                var parameters = new DynamicParameters();
                parameters.Add("BORD_ID", (BORD_ID == null ? 0 : Convert.ToInt32(BORD_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<BORDRO>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<BORDRO>> GetAllAsync()
        {
            try
            {

                var query = "getBORDRO";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<BORDRO>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BORDRO> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM BORDRO WHERE BORD_ID = @BORD_ID";
                var parameters = new DynamicParameters();
                parameters.Add("BORD_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<BORDRO>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(BORDRO entity)
        {
            try
            {
                var query = "UpdateBORDRODetails";
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


