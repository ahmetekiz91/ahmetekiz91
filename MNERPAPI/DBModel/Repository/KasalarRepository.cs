
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
    public class KasalarRepository : BaseRepository, IRepository.IKasalarRepository
    {

        public KasalarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Kasalar entity)
        {

            try
            {
                var query = "AddKasalar";
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

        public async Task<bool> DeleteAsync(object Kasa_ID)
        {
            try
            {
                var query = "DeleteKasalar";

                var parameters = new DynamicParameters();
                parameters.Add("Kasa_ID", (Kasa_ID == null ? 0 : Convert.ToInt32(Kasa_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Kasalar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Kasalar>> GetAllAsync()
        {
            try
            {

                var query = "getKasalar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Kasalar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Kasalar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Kasalar WHERE Kasa_ID = @Kasa_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Kasa_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Kasalar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Kasalar entity)
        {
            try
            {
                var query = "UpdateKasalarDetails";
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


