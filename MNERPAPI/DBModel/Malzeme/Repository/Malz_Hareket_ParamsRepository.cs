
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
    public class Malz_Hareket_ParamsRepository : BaseRepository, IRepository.IMalz_Hareket_ParamsRepository
    {

        public Malz_Hareket_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Malz_Hareket_Params entity)
        {

            try
            {
                var query = "AddMalz_Hareket_Params";
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

        public async Task<bool> DeleteAsync(object Malz_Har_Par_ID)
        {
            try
            {
                var query = "DeleteMalz_Hareket_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Malz_Har_Par_ID", (Malz_Har_Par_ID == null ? 0 : Convert.ToInt32(Malz_Har_Par_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Malz_Hareket_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Malz_Hareket_Params>> GetAllAsync()
        {
            try
            {

                var query = "getMalz_Hareket_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Malz_Hareket_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Malz_Hareket_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Malz_Hareket_Params WHERE Malz_Har_Par_ID = @Malz_Har_Par_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Malz_Har_Par_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Malz_Hareket_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Malz_Hareket_Params entity)
        {
            try
            {
                var query = "UpdateMalz_Hareket_ParamsDetails";
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


