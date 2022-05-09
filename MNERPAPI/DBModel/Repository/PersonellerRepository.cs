
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
    public class PersonellerRepository : BaseRepository, IRepository.IPersonellerRepository
    {

        public PersonellerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Personeller entity)
        {

            try
            {
                var query = "AddPersoneller";
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

        public async Task<bool> DeleteAsync(object Per_ID)
        {
            try
            {
                var query = "DeletePersoneller";

                var parameters = new DynamicParameters();
                parameters.Add("Per_ID", (Per_ID == null ? 0 : Convert.ToInt32(Per_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Personeller>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Personeller>> GetAllAsync()
        {
            try
            {

                var query = "getPersoneller";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Personeller>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Personeller> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Personeller WHERE Per_ID = @Per_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Per_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Personeller>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Personeller entity)
        {
            try
            {
                var query = "UpdatePersonellerDetails";
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


