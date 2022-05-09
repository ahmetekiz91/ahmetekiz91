
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
    public class Hat_MakinalarRepository : BaseRepository, IRepository.IHat_MakinalarRepository
    {

        public Hat_MakinalarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Hat_Makinalar entity)
        {

            try
            {
                var query = "AddHat_Makinalar";
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

        public async Task<bool> DeleteAsync(object Hat_Mak_ID)
        {
            try
            {
                var query = "DeleteHat_Makinalar";

                var parameters = new DynamicParameters();
                parameters.Add("Hat_Mak_ID", (Hat_Mak_ID == null ? 0 : Convert.ToInt32(Hat_Mak_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Hat_Makinalar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Hat_Makinalar>> GetAllAsync()
        {
            try
            {

                var query = "getHat_Makinalar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Hat_Makinalar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Hat_Makinalar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Hat_Makinalar WHERE Hat_Mak_ID = @Hat_Mak_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Hat_Mak_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Hat_Makinalar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Hat_Makinalar entity)
        {
            try
            {
                var query = "UpdateHat_MakinalarDetails";
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


