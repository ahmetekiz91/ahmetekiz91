
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
    public class MakinalarRepository : BaseRepository, IRepository.IMakinalarRepository
    {

        public MakinalarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Makinalar entity)
        {

            try
            {
                var query = "AddMakinalar";
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

        public async Task<bool> DeleteAsync(object Mak_ID)
        {
            try
            {
                var query = "DeleteMakinalar";

                var parameters = new DynamicParameters();
                parameters.Add("Mak_ID", (Mak_ID == null ? 0 : Convert.ToInt32(Mak_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Makinalar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Makinalar>> GetAllAsync()
        {
            try
            {

                var query = "getMakinalar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Makinalar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Makinalar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Makinalar WHERE Mak_ID = @Mak_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Mak_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Makinalar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Makinalar entity)
        {
            try
            {
                var query = "UpdateMakinalarDetails";
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


