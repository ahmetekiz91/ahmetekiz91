
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
    public class Kul_RollerRepository : BaseRepository, IRepository.IKul_RollerRepository
    {

        public Kul_RollerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Kul_Roller entity)
        {

            try
            {
                var query = "AddKul_Roller";
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

        public async Task<bool> DeleteAsync(object User_Roles_ID)
        {
            try
            {
                var query = "DeleteKul_Roller";

                var parameters = new DynamicParameters();
                parameters.Add("User_Roles_ID", (User_Roles_ID == null ? 0 : Convert.ToInt32(User_Roles_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Kul_Roller>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Kul_Roller>> GetAllAsync()
        {
            try
            {

                var query = "getKul_Roller";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Kul_Roller>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Kul_Roller> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Kul_Roller WHERE User_Roles_ID = @User_Roles_ID";
                var parameters = new DynamicParameters();
                parameters.Add("User_Roles_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Kul_Roller>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Kul_Roller entity)
        {
            try
            {
                var query = "UpdateKul_RollerDetails";
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


