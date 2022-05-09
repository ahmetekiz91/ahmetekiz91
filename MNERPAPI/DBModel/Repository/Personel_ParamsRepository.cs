
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
    public class Personel_ParamsRepository : BaseRepository, IRepository.IPersonel_ParamsRepository
    {

        public Personel_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Personel_Params entity)
        {

            try
            {
                var query = "AddPersonel_Params";
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

        public async Task<bool> DeleteAsync(object Personel_Params_ID)
        {
            try
            {
                var query = "DeletePersonel_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Personel_Params_ID", (Personel_Params_ID == null ? 0 : Convert.ToInt32(Personel_Params_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Personel_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Personel_Params>> GetAllAsync()
        {
            try
            {

                var query = "getPersonel_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Personel_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Personel_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Personel_Params WHERE Personel_Params_ID = @Personel_Params_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Personel_Params_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Personel_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Personel_Params entity)
        {
            try
            {
                var query = "UpdatePersonel_ParamsDetails";
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


