
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
    public class Malz_DocsRepository : BaseRepository, IRepository.IMalz_DocsRepository
    {

        public Malz_DocsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Malz_Docs entity)
        {

            try
            {
                var query = "AddMalz_Docs";
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

        public async Task<bool> DeleteAsync(object Malz_Dok_ID)
        {
            try
            {
                var query = "DeleteMalz_Docs";

                var parameters = new DynamicParameters();
                parameters.Add("Malz_Dok_ID", (Malz_Dok_ID == null ? 0 : Convert.ToInt32(Malz_Dok_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Malz_Docs>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Malz_Docs>> GetAllAsync()
        {
            try
            {

                var query = "getMalz_Docs";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Malz_Docs>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Malz_Docs> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Malz_Docs WHERE Malz_Dok_ID = @Malz_Dok_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Malz_Dok_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Malz_Docs>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Malz_Docs entity)
        {
            try
            {
                var query = "UpdateMalz_DocsDetails";
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


