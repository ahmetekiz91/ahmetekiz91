
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
    public class KontrollerRepository : BaseRepository, IRepository.IKontrollerRepository
    {

        public KontrollerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Kontroller entity)
        {

            try
            {
                var query = "AddKontroller";
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

        public async Task<bool> DeleteAsync(object Kont_ID)
        {
            try
            {
                var query = "DeleteKontroller";

                var parameters = new DynamicParameters();
                parameters.Add("Kont_ID", (Kont_ID == null ? 0 : Convert.ToInt32(Kont_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Kontroller>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Kontroller>> GetAllAsync()
        {
            try
            {

                var query = "getKontroller";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Kontroller>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Kontroller> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Kontroller WHERE Kont_ID = @Kont_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Kont_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Kontroller>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Kontroller entity)
        {
            try
            {
                var query = "UpdateKontrollerDetails";
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


