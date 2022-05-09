
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
    public class Sip_Kalem_ParamsRepository : BaseRepository, IRepository.ISip_Kalem_ParamsRepository
    {

        public Sip_Kalem_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Sip_Kalem_Params entity)
        {

            try
            {
                var query = "AddSip_Kalem_Params";
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

        public async Task<bool> DeleteAsync(object Sip_Kalem_Par_ID)
        {
            try
            {
                var query = "DeleteSip_Kalem_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Sip_Kalem_Par_ID", (Sip_Kalem_Par_ID == null ? 0 : Convert.ToInt32(Sip_Kalem_Par_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Sip_Kalem_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Sip_Kalem_Params>> GetAllAsync()
        {
            try
            {

                var query = "getSip_Kalem_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Sip_Kalem_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Sip_Kalem_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Sip_Kalem_Params WHERE Sip_Kalem_Par_ID = @Sip_Kalem_Par_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Sip_Kalem_Par_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Sip_Kalem_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Sip_Kalem_Params entity)
        {
            try
            {
                var query = "UpdateSip_Kalem_ParamsDetails";
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


