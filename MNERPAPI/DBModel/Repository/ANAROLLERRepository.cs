
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

    public class ANAROLLERRepository : BaseRepository, IRepository.IANAROLLERRepository
    {

        public ANAROLLERRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(ANAROLLER entity)
        {

            try
            {

                entity.CDATE = DateTime.Now;
                var query = "AddANAROLLER";
                var parameters = new DynamicParameters();
                parameters.Add("@CDATE", entity.CDATE, DbType.DateTime);
                parameters.Add("@ROL_ADI", entity.ROL_ADI, DbType.String);
                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync(query, parameters, commandType: CommandType.StoredProcedure)); return true;
                }
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
        }

        public async Task<bool> DeleteAsync(object ANA_ROL_ID)
        {
            try
            {
                var query = "DeleteANAROLLER";

                var parameters = new DynamicParameters();
                parameters.Add("ANA_ROL_ID", (ANA_ROL_ID == null ? 0 : Convert.ToInt32(ANA_ROL_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<ANAROLLER>(query, parameters, commandType: CommandType.StoredProcedure));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<ANAROLLER>> GetAllAsync()
        {
            try
            {

                var query = "getANAROLLER";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<ANAROLLER>(query, commandType: CommandType.StoredProcedure)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<ANAROLLER> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM ANAROLLER WHERE ANA_ROL_ID = @ANA_ROL_ID";
                var parameters = new DynamicParameters();
                parameters.Add("ANA_ROL_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<ANAROLLER>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(ANAROLLER entity)
        {
            try
            {
                var query = "UpdateANAROLLERDetails";
                var parameters = new DynamicParameters();
                parameters.Add("@UDATE", entity.UDATE, DbType.DateTime);
                parameters.Add("@ROL_ADI", entity.ROL_ADI, DbType.String);
                parameters.Add("@ANA_ROL_ID", entity.ANA_ROL_ID, DbType.Int32);

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


