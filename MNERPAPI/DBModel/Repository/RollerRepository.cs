
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
    public class RollerRepository : BaseRepository, IRepository.IRollerRepository
    {

        public RollerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Roller entity)
        {

            try
            {
                var query = "AddRoller";
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

        public async Task<bool> DeleteAsync(object Rol_ID)
        {
            try
            {
                var query = "DeleteRoller";

                var parameters = new DynamicParameters();
                parameters.Add("Rol_ID", (Rol_ID == null ? 0 : Convert.ToInt32(Rol_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Roller>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Roller>> GetAllAsync()
        {
            try
            {

                var query = "getRoller";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Roller>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Roller> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Roller WHERE Rol_ID = @Rol_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Rol_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Roller>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Roller entity)
        {
            try
            {
                var query = "UpdateRollerDetails";
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


