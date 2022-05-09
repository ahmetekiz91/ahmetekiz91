
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
    public class SevkiyatlarRepository : BaseRepository, IRepository.ISevkiyatlarRepository
    {

        public SevkiyatlarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Sevkiyatlar entity)
        {

            try
            {
                var query = "AddSevkiyatlar";
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

        public async Task<bool> DeleteAsync(object Sevk_ID)
        {
            try
            {
                var query = "DeleteSevkiyatlar";

                var parameters = new DynamicParameters();
                parameters.Add("Sevk_ID", (Sevk_ID == null ? 0 : Convert.ToInt32(Sevk_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Sevkiyatlar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Sevkiyatlar>> GetAllAsync()
        {
            try
            {

                var query = "getSevkiyatlar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Sevkiyatlar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Sevkiyatlar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Sevkiyatlar WHERE Sevk_ID = @Sevk_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Sevk_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Sevkiyatlar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Sevkiyatlar entity)
        {
            try
            {
                var query = "UpdateSevkiyatlarDetails";
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


