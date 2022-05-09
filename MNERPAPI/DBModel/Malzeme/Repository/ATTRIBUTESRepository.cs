
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
    public class ATTRIBUTESRepository : BaseRepository, IRepository.IATTRIBUTESRepository
    {

        public ATTRIBUTESRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(ATTRIBUTES entity)
        {

            try
            {
                var query = "AddATTRIBUTES";
                var parameters = new DynamicParameters();
                parameters.Add("@ATTCODE", entity.ATTCODE, DbType.String);
                parameters.Add("@ATTDESCRIBTION", entity.ATTDESCRIBTION, DbType.String);
                parameters.Add("@VIEWNAME", entity.VIEWNAME, DbType.String);
                parameters.Add("@SYNTAX", entity.SYNTAX, DbType.String);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure)); return true;
                }
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
        }

        public async Task<bool> DeleteAsync(object ATT_ID)
        {
            try
            {
                var query = "DeleteATTRIBUTES";

                var parameters = new DynamicParameters();
                parameters.Add("ATT_ID", (ATT_ID == null ? 0 : Convert.ToInt32(ATT_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<ATTRIBUTES>(query, parameters, commandType: CommandType.StoredProcedure));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<ATTRIBUTES>> GetAllAsync()
        {
            try
            {

                var query = "getAllATTRIBUTES";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<ATTRIBUTES>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<ATTRIBUTES> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM ATTRIBUTES WHERE ATT_ID = @ATT_ID";
                var parameters = new DynamicParameters();
                parameters.Add("ATT_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<ATTRIBUTES>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(ATTRIBUTES entity)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("ATT_ID", entity.ATT_ID, DbType.Int32);
                parameters.Add("ATTCODE", entity.ATTCODE, DbType.String);
                parameters.Add("ATTDESCRIBTION", entity.ATTDESCRIBTION, DbType.String);
                parameters.Add("VIEWNAME", entity.VIEWNAME, DbType.String);
                parameters.Add("SYNTAX", entity.SYNTAX, DbType.String);
                var query = "UpdateATTRIBUTESDetails";
                using (var connection = CreateConnection())
                {
                    var res = (await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure));
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


