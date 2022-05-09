
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
    public class Vardiya_Kisi_ParamsRepository : BaseRepository, IRepository.IVardiya_Kisi_ParamsRepository
    {

        public Vardiya_Kisi_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Vardiya_Kisi_Params entity)
        {

            try
            {
                var query = "AddVardiya_Kisi_Params";
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

        public async Task<bool> DeleteAsync(object Var_Kisi_Par_ID)
        {
            try
            {
                var query = "DeleteVardiya_Kisi_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Var_Kisi_Par_ID", (Var_Kisi_Par_ID == null ? 0 : Convert.ToInt32(Var_Kisi_Par_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Vardiya_Kisi_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Vardiya_Kisi_Params>> GetAllAsync()
        {
            try
            {

                var query = "getVardiya_Kisi_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Vardiya_Kisi_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Vardiya_Kisi_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Vardiya_Kisi_Params WHERE Var_Kisi_Par_ID = @Var_Kisi_Par_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Var_Kisi_Par_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Vardiya_Kisi_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Vardiya_Kisi_Params entity)
        {
            try
            {
                var query = "UpdateVardiya_Kisi_ParamsDetails";
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


