
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
    public class Talep_DetayRepository : BaseRepository, IRepository.ITalep_DetayRepository
    {

        public Talep_DetayRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Talep_Detay entity)
        {

            try
            {
                var query = "AddTalep_Detay";
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

        public async Task<bool> DeleteAsync(object TLP_DET_ID)
        {
            try
            {
                var query = "DeleteTalep_Detay";

                var parameters = new DynamicParameters();
                parameters.Add("TLP_DET_ID", (TLP_DET_ID == null ? 0 : Convert.ToInt32(TLP_DET_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Talep_Detay>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Talep_Detay>> GetAllAsync()
        {
            try
            {

                var query = "getTalep_Detay";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Talep_Detay>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Talep_Detay> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Talep_Detay WHERE TLP_DET_ID = @TLP_DET_ID";
                var parameters = new DynamicParameters();
                parameters.Add("TLP_DET_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Talep_Detay>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Talep_Detay entity)
        {
            try
            {
                var query = "UpdateTalep_DetayDetails";
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


