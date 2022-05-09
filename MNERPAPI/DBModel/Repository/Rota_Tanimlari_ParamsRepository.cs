
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
    public class Rota_Tanimlari_ParamsRepository : BaseRepository, IRepository.IRota_Tanimlari_ParamsRepository
    {

        public Rota_Tanimlari_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Rota_Tanimlari_Params entity)
        {

            try
            {
                var query = "AddRota_Tanimlari_Params";
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

        public async Task<bool> DeleteAsync(object Rot_Tanim_Par_ID)
        {
            try
            {
                var query = "DeleteRota_Tanimlari_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Rot_Tanim_Par_ID", (Rot_Tanim_Par_ID == null ? 0 : Convert.ToInt32(Rot_Tanim_Par_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Rota_Tanimlari_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Rota_Tanimlari_Params>> GetAllAsync()
        {
            try
            {

                var query = "getRota_Tanimlari_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Rota_Tanimlari_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Rota_Tanimlari_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Rota_Tanimlari_Params WHERE Rot_Tanim_Par_ID = @Rot_Tanim_Par_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Rot_Tanim_Par_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Rota_Tanimlari_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Rota_Tanimlari_Params entity)
        {
            try
            {
                var query = "UpdateRota_Tanimlari_ParamsDetails";
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


