
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
    public class Uretim_Emir_ParamsRepository : BaseRepository, IRepository.IUretim_Emir_ParamsRepository
    {

        public Uretim_Emir_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Uretim_Emir_Params entity)
        {

            try
            {
                var query = "AddUretim_Emir_Params";
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

        public async Task<bool> DeleteAsync(object Uret_Emir_Param_ID)
        {
            try
            {
                var query = "DeleteUretim_Emir_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Uret_Emir_Param_ID", (Uret_Emir_Param_ID == null ? 0 : Convert.ToInt32(Uret_Emir_Param_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Uretim_Emir_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Uretim_Emir_Params>> GetAllAsync()
        {
            try
            {

                var query = "getUretim_Emir_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Uretim_Emir_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Uretim_Emir_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Uretim_Emir_Params WHERE Uret_Emir_Param_ID = @Uret_Emir_Param_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Uret_Emir_Param_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Uretim_Emir_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Uretim_Emir_Params entity)
        {
            try
            {
                var query = "UpdateUretim_Emir_ParamsDetails";
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


