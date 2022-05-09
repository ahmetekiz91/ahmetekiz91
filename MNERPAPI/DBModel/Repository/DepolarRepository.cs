
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
    public class DepolarRepository : BaseRepository, IRepository.IDepolarRepository
    {

        public DepolarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Depolar entity)
        {

            try
            {
                var query = "AddDepolar";
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

        public async Task<bool> DeleteAsync(object Depo_ID)
        {
            try
            {
                var query = "DeleteDepolar";

                var parameters = new DynamicParameters();
                parameters.Add("Depo_ID", (Depo_ID == null ? 0 : Convert.ToInt32(Depo_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Depolar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Depolar>> GetAllAsync()
        {
            try
            {

                var query = "getDepolar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Depolar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Depolar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Depolar WHERE Depo_ID = @Depo_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Depo_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Depolar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Depolar entity)
        {
            try
            {
                var query = "UpdateDepolarDetails";
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


