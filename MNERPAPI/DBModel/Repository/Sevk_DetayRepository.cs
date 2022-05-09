
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
    public class Sevk_DetayRepository : BaseRepository, IRepository.ISevk_DetayRepository
    {

        public Sevk_DetayRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Sevk_Detay entity)
        {

            try
            {
                var query = "AddSevk_Detay";
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

        public async Task<bool> DeleteAsync(object Sevk_Detay_ID)
        {
            try
            {
                var query = "DeleteSevk_Detay";

                var parameters = new DynamicParameters();
                parameters.Add("Sevk_Detay_ID", (Sevk_Detay_ID == null ? 0 : Convert.ToInt32(Sevk_Detay_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Sevk_Detay>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Sevk_Detay>> GetAllAsync()
        {
            try
            {

                var query = "getSevk_Detay";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Sevk_Detay>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Sevk_Detay> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Sevk_Detay WHERE Sevk_Detay_ID = @Sevk_Detay_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Sevk_Detay_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Sevk_Detay>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Sevk_Detay entity)
        {
            try
            {
                var query = "UpdateSevk_DetayDetails";
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


