
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
    public class Tek_Revizyon_ParamsRepository : BaseRepository, IRepository.ITek_Revizyon_ParamsRepository
    {

        public Tek_Revizyon_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Tek_Revizyon_Params entity)
        {

            try
            {
                var query = "AddTek_Revizyon_Params";
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

        public async Task<bool> DeleteAsync(object Tek_Rev_Params_ID)
        {
            try
            {
                var query = "DeleteTek_Revizyon_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Tek_Rev_Params_ID", (Tek_Rev_Params_ID == null ? 0 : Convert.ToInt32(Tek_Rev_Params_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Tek_Revizyon_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Tek_Revizyon_Params>> GetAllAsync()
        {
            try
            {

                var query = "getTek_Revizyon_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Tek_Revizyon_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Tek_Revizyon_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Tek_Revizyon_Params WHERE Tek_Rev_Params_ID = @Tek_Rev_Params_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Tek_Rev_Params_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Tek_Revizyon_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Tek_Revizyon_Params entity)
        {
            try
            {
                var query = "UpdateTek_Revizyon_ParamsDetails";
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


