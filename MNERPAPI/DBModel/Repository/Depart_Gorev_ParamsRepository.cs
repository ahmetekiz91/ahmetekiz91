
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
    public class Depart_Gorev_ParamsRepository : BaseRepository, IRepository.IDepart_Gorev_ParamsRepository
    {

        public Depart_Gorev_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Depart_Gorev_Params entity)
        {

            try
            {
                var query = "AddDepart_Gorev_Params";
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

        public async Task<bool> DeleteAsync(object Depart_Gorev_Params_ID)
        {
            try
            {
                var query = "DeleteDepart_Gorev_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Depart_Gorev_Params_ID", (Depart_Gorev_Params_ID == null ? 0 : Convert.ToInt32(Depart_Gorev_Params_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Depart_Gorev_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Depart_Gorev_Params>> GetAllAsync()
        {
            try
            {

                var query = "getDepart_Gorev_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Depart_Gorev_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Depart_Gorev_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Depart_Gorev_Params WHERE Depart_Gorev_Params_ID = @Depart_Gorev_Params_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Depart_Gorev_Params_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Depart_Gorev_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Depart_Gorev_Params entity)
        {
            try
            {
                var query = "UpdateDepart_Gorev_ParamsDetails";
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


