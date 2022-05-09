
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
    public class IlcelerRepository : BaseRepository, IRepository.IIlcelerRepository
    {

        public IlcelerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Ilceler entity)
        {

            try
            {
                var query = "AddIlceler";
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

        public async Task<bool> DeleteAsync(object Ilce_ID)
        {
            try
            {
                var query = "DeleteIlceler";

                var parameters = new DynamicParameters();
                parameters.Add("Ilce_ID", (Ilce_ID == null ? 0 : Convert.ToInt32(Ilce_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Ilceler>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Ilceler>> GetAllAsync()
        {
            try
            {

                var query = "getIlceler";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Ilceler>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Ilceler> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Ilceler WHERE Ilce_ID = @Ilce_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Ilce_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Ilceler>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Ilceler entity)
        {
            try
            {
                var query = "UpdateIlcelerDetails";
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


