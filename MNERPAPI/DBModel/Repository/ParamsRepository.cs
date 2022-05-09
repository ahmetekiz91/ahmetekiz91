
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
    public class ParamsRepository : BaseRepository, IRepository.IParamsRepository
    {

        public ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Params entity)
        {

            try
            {
                var query = "AddParams";
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

        public async Task<bool> DeleteAsync(object Cari_Kart_Params_ID)
        {
            try
            {
                var query = "DeleteParams";

                var parameters = new DynamicParameters();
                parameters.Add("Cari_Kart_Params_ID", (Cari_Kart_Params_ID == null ? 0 : Convert.ToInt32(Cari_Kart_Params_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Params>> GetAllAsync()
        {
            try
            {

                var query = "getParams";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Params WHERE Cari_Kart_Params_ID = @Cari_Kart_Params_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Cari_Kart_Params_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Params entity)
        {
            try
            {
                var query = "UpdateParamsDetails";
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


