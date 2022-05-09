
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
    public class DestekTalepRepository : BaseRepository, IRepository.IDestekTalepRepository
    {

        public DestekTalepRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(DestekTalep entity)
        {

            try
            {
                var query = "AddDestekTalep";
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

        public async Task<bool> DeleteAsync(object ID)
        {
            try
            {
                var query = "DeleteDestekTalep";

                var parameters = new DynamicParameters();
                parameters.Add("ID", (ID == null ? 0 : Convert.ToInt32(ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<DestekTalep>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<DestekTalep>> GetAllAsync()
        {
            try
            {

                var query = "getDestekTalep";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<DestekTalep>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<DestekTalep> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM DestekTalep WHERE ID = @ID";
                var parameters = new DynamicParameters();
                parameters.Add("ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<DestekTalep>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(DestekTalep entity)
        {
            try
            {
                var query = "UpdateDestekTalepDetails";
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


