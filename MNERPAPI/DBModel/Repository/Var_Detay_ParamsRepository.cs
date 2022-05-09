
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
    public class Var_Detay_ParamsRepository : BaseRepository, IRepository.IVar_Detay_ParamsRepository
    {

        public Var_Detay_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Var_Detay_Params entity)
        {

            try
            {
                var query = "AddVar_Detay_Params";
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

        public async Task<bool> DeleteAsync(object Var_Detay_Par_ID)
        {
            try
            {
                var query = "DeleteVar_Detay_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Var_Detay_Par_ID", (Var_Detay_Par_ID == null ? 0 : Convert.ToInt32(Var_Detay_Par_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Var_Detay_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Var_Detay_Params>> GetAllAsync()
        {
            try
            {

                var query = "getVar_Detay_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Var_Detay_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Var_Detay_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Var_Detay_Params WHERE Var_Detay_Par_ID = @Var_Detay_Par_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Var_Detay_Par_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Var_Detay_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Var_Detay_Params entity)
        {
            try
            {
                var query = "UpdateVar_Detay_ParamsDetails";
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


