
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
    public class Teklif_Sevk_PlaniRepository : BaseRepository, IRepository.ITeklif_Sevk_PlaniRepository
    {

        public Teklif_Sevk_PlaniRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Teklif_Sevk_Plani entity)
        {

            try
            {
                var query = "AddTeklif_Sevk_Plani";
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

        public async Task<bool> DeleteAsync(object Sevk_Plan_ID)
        {
            try
            {
                var query = "DeleteTeklif_Sevk_Plani";

                var parameters = new DynamicParameters();
                parameters.Add("Sevk_Plan_ID", (Sevk_Plan_ID == null ? 0 : Convert.ToInt32(Sevk_Plan_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Teklif_Sevk_Plani>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Teklif_Sevk_Plani>> GetAllAsync()
        {
            try
            {

                var query = "getTeklif_Sevk_Plani";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Teklif_Sevk_Plani>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Teklif_Sevk_Plani> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Teklif_Sevk_Plani WHERE Sevk_Plan_ID = @Sevk_Plan_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Sevk_Plan_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Teklif_Sevk_Plani>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Teklif_Sevk_Plani entity)
        {
            try
            {
                var query = "UpdateTeklif_Sevk_PlaniDetails";
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


