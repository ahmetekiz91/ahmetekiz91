
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
    public class Siparisler_ParamsRepository : BaseRepository, IRepository.ISiparisler_ParamsRepository
    {

        public Siparisler_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Siparisler_Params entity)
        {

            try
            {
                var query = "AddSiparisler_Params";
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

        public async Task<bool> DeleteAsync(object Sip_Par_ID)
        {
            try
            {
                var query = "DeleteSiparisler_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Sip_Par_ID", (Sip_Par_ID == null ? 0 : Convert.ToInt32(Sip_Par_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Siparisler_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Siparisler_Params>> GetAllAsync()
        {
            try
            {

                var query = "getSiparisler_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Siparisler_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Siparisler_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Siparisler_Params WHERE Sip_Par_ID = @Sip_Par_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Sip_Par_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Siparisler_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Siparisler_Params entity)
        {
            try
            {
                var query = "UpdateSiparisler_ParamsDetails";
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


