using Dapper;
using DBModel.IRepository;
using DBModel.Model;
using DBModel.Utility;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace DBModel.Infrastruce
{
    public class USERSRepository : BaseRepository,  IRepository.IUSERSRepository
    {


        public USERSRepository(IConfiguration configuration) :
              base(configuration)
        {
        }

        public string mesaj = "";
        public void Dispose()
        {

        }
        public async Task<bool> CreateAsync(USERS entity)
        {

            try
            {
                var query = "AddUSERS";
                var parameters = new DynamicParameters(); 
            
                parameters.Add(@"CDate", entity.CDate, DbType.DateTime);
                parameters.Add(@"NAME", entity.NAME, DbType.String);
                parameters.Add(@"SURNAME", entity.SURNAME, DbType.String);
                parameters.Add(@"EMAIL", entity.EMAIL, DbType.String);
                parameters.Add(@"PASS", entity.PASS, DbType.String);
                parameters.Add(@"Hash", entity.Hash, DbType.String);
                parameters.Add(@"USERN", entity.USERN, DbType.String);
                int f = 0;
                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync(query, parameters, commandType: CommandType.StoredProcedure)); return true;
                }
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
            return false;
        }

        public async Task<bool> DeleteAsync(object USR_ID)
        {
            try
            {
                var query = "DeleteUSERS";

                var parameters = new DynamicParameters();
                parameters.Add("USR_ID", (USR_ID == null ? 0 : Convert.ToInt32(USR_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<USERS>(query, parameters, commandType: CommandType.StoredProcedure));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<USERS>> GetAllAsync()
        {
            try
            {

                var query = "getAllUSERS";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<USERS>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<USERS> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM USERS WHERE USR_ID = @USR_ID";
                var parameters = new DynamicParameters();
                parameters.Add("USR_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<USERS>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(USERS entity)
        {
            try
            {
                int f = 0;
                var query = "UpdateUSERSDetails";
                var parameters = new DynamicParameters(); parameters.Add(@"USR_ID", entity.USR_ID);
                parameters.Add(@"CDate", entity.CDate, DbType.DateTime);
                parameters.Add(@"NAME", entity.NAME, DbType.String);
                parameters.Add(@"SURNAME", entity.SURNAME, DbType.String);
                parameters.Add(@"EMAIL", entity.EMAIL, DbType.String);
                parameters.Add(@"PASS", entity.PASS, DbType.String);
                parameters.Add(@"Hash", entity.Hash, DbType.String);
                parameters.Add(@"USERN", entity.USERN, DbType.String);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync(query, parameters, commandType: CommandType.StoredProcedure)); 
                    return true;
                }


            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
            return false;
           
        }

    }
}


