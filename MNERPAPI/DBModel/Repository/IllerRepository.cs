
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
    public class IllerRepository : BaseRepository, IRepository.IIllerRepository
    {

        public IllerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Iller entity)
        {

            try
            {
                var query = "AddIller";
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

        public async Task<bool> DeleteAsync(object Sehir_ID)
        {
            try
            {
                var query = "DeleteIller";

                var parameters = new DynamicParameters();
                parameters.Add("Sehir_ID", (Sehir_ID == null ? 0 : Convert.ToInt32(Sehir_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Iller>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Iller>> GetAllAsync()
        {
            try
            {

                var query = "getIller";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Iller>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Iller> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Iller WHERE Sehir_ID = @Sehir_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Sehir_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Iller>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Iller entity)
        {
            try
            {
                var query = "UpdateIllerDetails";
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


