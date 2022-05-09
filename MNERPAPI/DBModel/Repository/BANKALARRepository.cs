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
    public class BANKALARRepository : BaseRepository, IRepository.IBANKALARRepository
    {

        public BANKALARRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<bool> CreateAsync(BANKALAR entity)
        {

            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@BANKAKODU", entity.BANKAKODU, DbType.String);
                parameters.Add("@CDATE", entity.CDATE, DbType.DateTime);
                parameters.Add("@UDATE", entity.UDATE, DbType.DateTime);
                parameters.Add("@BANKAADI", entity.BANKAADI, DbType.String);
                parameters.Add("@SUBE", entity.SUBE, DbType.String);
                parameters.Add("@SEHIR", entity.SEHIR, DbType.String);
                parameters.Add("@ULKE", entity.ULKE, DbType.String);
                parameters.Add("@CUSR_ID", entity.CUSR_ID, DbType.Int32);
                parameters.Add("@UUSR_ID", entity.UUSR_ID, DbType.Int32);
                parameters.Add("@DOVIZ_ID", entity.DOVIZ_ID, DbType.Int32);

                var query = "AddBANKALAR";
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

        public async Task<bool> DeleteAsync(object ID)
        {
            try
            {
                var query = "DeleteBANKALAR";

                var parameters = new DynamicParameters();
                parameters.Add("ID", (ID == null ? 0 : Convert.ToInt32(ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {

                    var res = (await connection.QueryFirstOrDefaultAsync<BANKALAR>(query, parameters, commandType: CommandType.StoredProcedure));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<BANKALAR>> GetAllAsync()
        {
            try
            {

                var query = "getBANKALAR";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<BANKALAR>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BANKALAR> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM BANKALAR WHERE ID = @ID";
                var parameters = new DynamicParameters();
                parameters.Add("ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<BANKALAR>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(BANKALAR entity)
        {
            try
            {
                var query = "UpdateBANKALARDetails";
                using (var connection = CreateConnection())
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@BANKAKODU", entity.BANKAKODU, DbType.String);
                    parameters.Add("@CDATE", entity.CDATE, DbType.DateTime);
                    parameters.Add("@UDATE", entity.UDATE, DbType.DateTime);
                    parameters.Add("@BANKAADI", entity.BANKAADI, DbType.String);
                    parameters.Add("@SUBE", entity.SUBE, DbType.String);
                    parameters.Add("@SEHIR", entity.SEHIR, DbType.String);
                    parameters.Add("@ULKE", entity.ULKE, DbType.String);
                    parameters.Add("@CUSR_ID", entity.CUSR_ID, DbType.Int32);
                    parameters.Add("@UUSR_ID", entity.UUSR_ID, DbType.Int32);
                    parameters.Add("@DOVIZ_ID", entity.DOVIZ_ID, DbType.Int32);
                    parameters.Add("@ID", entity.ID, DbType.Int32);
                 
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


