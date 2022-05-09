
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
    public class Gorev_TalepRepository : BaseRepository, IRepository.IGorev_TalepRepository
    {

        public Gorev_TalepRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Gorev_Talep entity)
        {

            try
            {
                var query = "AddGorev_Talep";
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

        public async Task<bool> DeleteAsync(object Gorev_ID)
        {
            try
            {
                var query = "DeleteGorev_Talep";

                var parameters = new DynamicParameters();
                parameters.Add("Gorev_ID", (Gorev_ID == null ? 0 : Convert.ToInt32(Gorev_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Gorev_Talep>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Gorev_Talep>> GetAllAsync()
        {
            try
            {

                var query = "getGorev_Talep";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Gorev_Talep>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Gorev_Talep> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Gorev_Talep WHERE Gorev_ID = @Gorev_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Gorev_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Gorev_Talep>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Gorev_Talep entity)
        {
            try
            {
                var query = "UpdateGorev_TalepDetails";
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


