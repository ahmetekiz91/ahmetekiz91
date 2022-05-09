
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
    public class VardiyalarRepository : BaseRepository, IRepository.IVardiyalarRepository
    {

        public VardiyalarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Vardiyalar entity)
        {

            try
            {
                var query = "AddVardiyalar";
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

        public async Task<bool> DeleteAsync(object Var_ID)
        {
            try
            {
                var query = "DeleteVardiyalar";

                var parameters = new DynamicParameters();
                parameters.Add("Var_ID", (Var_ID == null ? 0 : Convert.ToInt32(Var_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Vardiyalar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Vardiyalar>> GetAllAsync()
        {
            try
            {

                var query = "getVardiyalar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Vardiyalar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Vardiyalar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Vardiyalar WHERE Var_ID = @Var_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Var_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Vardiyalar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Vardiyalar entity)
        {
            try
            {
                var query = "UpdateVardiyalarDetails";
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


