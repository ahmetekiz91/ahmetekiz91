
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
    public class Sevk_PlaniRepository : BaseRepository, IRepository.ISevk_PlaniRepository
    {

        public Sevk_PlaniRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Sevk_Plani entity)
        {

            try
            {
                var query = "AddSevk_Plani";
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

        public async Task<bool> DeleteAsync(object Sevk_Plan_ID)
        {
            try
            {
                var query = "DeleteSevk_Plani";

                var parameters = new DynamicParameters();
                parameters.Add("Sevk_Plan_ID", (Sevk_Plan_ID == null ? 0 : Convert.ToInt32(Sevk_Plan_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Sevk_Plani>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Sevk_Plani>> GetAllAsync()
        {
            try
            {

                var query = "getSevk_Plani";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Sevk_Plani>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Sevk_Plani> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Sevk_Plani WHERE Sevk_Plan_ID = @Sevk_Plan_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Sevk_Plan_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Sevk_Plani>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Sevk_Plani entity)
        {
            try
            {
                var query = "UpdateSevk_PlaniDetails";
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


