
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
    public class Sevk_DocsRepository : BaseRepository, IRepository.ISevk_DocsRepository
    {

        public Sevk_DocsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Sevk_Docs entity)
        {

            try
            {
                var query = "AddSevk_Docs";
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

        public async Task<bool> DeleteAsync(object Doc_ID)
        {
            try
            {
                var query = "DeleteSevk_Docs";

                var parameters = new DynamicParameters();
                parameters.Add("Doc_ID", (Doc_ID == null ? 0 : Convert.ToInt32(Doc_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Sevk_Docs>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Sevk_Docs>> GetAllAsync()
        {
            try
            {

                var query = "getSevk_Docs";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Sevk_Docs>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Sevk_Docs> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Sevk_Docs WHERE Doc_ID = @Doc_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Doc_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Sevk_Docs>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Sevk_Docs entity)
        {
            try
            {
                var query = "UpdateSevk_DocsDetails";
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


