
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
    public class Gorev_DurumlarRepository : BaseRepository, IRepository.IGorev_DurumlarRepository
    {

        public Gorev_DurumlarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Gorev_Durumlar entity)
        {

            try
            {
                var query = "AddGorev_Durumlar";
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

        public async Task<bool> DeleteAsync(object Gorev_Dur_ID)
        {
            try
            {
                var query = "DeleteGorev_Durumlar";

                var parameters = new DynamicParameters();
                parameters.Add("Gorev_Dur_ID", (Gorev_Dur_ID == null ? 0 : Convert.ToInt32(Gorev_Dur_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Gorev_Durumlar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Gorev_Durumlar>> GetAllAsync()
        {
            try
            {

                var query = "getGorev_Durumlar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Gorev_Durumlar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Gorev_Durumlar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Gorev_Durumlar WHERE Gorev_Dur_ID = @Gorev_Dur_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Gorev_Dur_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Gorev_Durumlar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Gorev_Durumlar entity)
        {
            try
            {
                var query = "UpdateGorev_DurumlarDetails";
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


