
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
    public class DuyurularRepository : BaseRepository, IRepository.IDuyurularRepository
    {

        public DuyurularRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Duyurular entity)
        {

            try
            {
                var query = "AddDuyurular";
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

        public async Task<bool> DeleteAsync(object Duy_ID)
        {
            try
            {
                var query = "DeleteDuyurular";

                var parameters = new DynamicParameters();
                parameters.Add("Duy_ID", (Duy_ID == null ? 0 : Convert.ToInt32(Duy_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Duyurular>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Duyurular>> GetAllAsync()
        {
            try
            {

                var query = "getDuyurular";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Duyurular>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Duyurular> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Duyurular WHERE Duy_ID = @Duy_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Duy_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Duyurular>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Duyurular entity)
        {
            try
            {
                var query = "UpdateDuyurularDetails";
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


