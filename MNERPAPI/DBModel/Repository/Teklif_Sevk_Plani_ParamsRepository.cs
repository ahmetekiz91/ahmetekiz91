
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
    public class Teklif_Sevk_Plani_ParamsRepository : BaseRepository, IRepository.ITeklif_Sevk_Plani_ParamsRepository
    {

        public Teklif_Sevk_Plani_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Teklif_Sevk_Plani_Params entity)
        {

            try
            {
                var query = "AddTeklif_Sevk_Plani_Params";
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

        public async Task<bool> DeleteAsync(object Teklif_Sevk_Plani_Par_ID)
        {
            try
            {
                var query = "DeleteTeklif_Sevk_Plani_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Teklif_Sevk_Plani_Par_ID", (Teklif_Sevk_Plani_Par_ID == null ? 0 : Convert.ToInt32(Teklif_Sevk_Plani_Par_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Teklif_Sevk_Plani_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Teklif_Sevk_Plani_Params>> GetAllAsync()
        {
            try
            {

                var query = "getTeklif_Sevk_Plani_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Teklif_Sevk_Plani_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Teklif_Sevk_Plani_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Teklif_Sevk_Plani_Params WHERE Teklif_Sevk_Plani_Par_ID = @Teklif_Sevk_Plani_Par_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Teklif_Sevk_Plani_Par_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Teklif_Sevk_Plani_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Teklif_Sevk_Plani_Params entity)
        {
            try
            {
                var query = "UpdateTeklif_Sevk_Plani_ParamsDetails";
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


