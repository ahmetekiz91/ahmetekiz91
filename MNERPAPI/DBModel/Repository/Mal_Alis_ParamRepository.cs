
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
    public class Mal_Alis_ParamRepository : BaseRepository, IRepository.IMal_Alis_ParamRepository
    {

        public Mal_Alis_ParamRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Mal_Alis_Param entity)
        {

            try
            {
                var query = "AddMal_Alis_Param";
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

        public async Task<bool> DeleteAsync(object Mal_Alim_Params_ID)
        {
            try
            {
                var query = "DeleteMal_Alis_Param";

                var parameters = new DynamicParameters();
                parameters.Add("Mal_Alim_Params_ID", (Mal_Alim_Params_ID == null ? 0 : Convert.ToInt32(Mal_Alim_Params_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Mal_Alis_Param>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Mal_Alis_Param>> GetAllAsync()
        {
            try
            {

                var query = "getMal_Alis_Param";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Mal_Alis_Param>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Mal_Alis_Param> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Mal_Alis_Param WHERE Mal_Alim_Params_ID = @Mal_Alim_Params_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Mal_Alim_Params_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Mal_Alis_Param>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Mal_Alis_Param entity)
        {
            try
            {
                var query = "UpdateMal_Alis_ParamDetails";
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


