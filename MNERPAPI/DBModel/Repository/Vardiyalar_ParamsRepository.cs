
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
    public class Vardiyalar_ParamsRepository : BaseRepository, IRepository.IVardiyalar_ParamsRepository
    {

        public Vardiyalar_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Vardiyalar_Params entity)
        {

            try
            {
                var query = "AddVardiyalar_Params";
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

        public async Task<bool> DeleteAsync(object Vardiya_Params_ID)
        {
            try
            {
                var query = "DeleteVardiyalar_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Vardiya_Params_ID", (Vardiya_Params_ID == null ? 0 : Convert.ToInt32(Vardiya_Params_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Vardiyalar_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Vardiyalar_Params>> GetAllAsync()
        {
            try
            {

                var query = "getVardiyalar_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Vardiyalar_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Vardiyalar_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Vardiyalar_Params WHERE Vardiya_Params_ID = @Vardiya_Params_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Vardiya_Params_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Vardiyalar_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Vardiyalar_Params entity)
        {
            try
            {
                var query = "UpdateVardiyalar_ParamsDetails";
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


