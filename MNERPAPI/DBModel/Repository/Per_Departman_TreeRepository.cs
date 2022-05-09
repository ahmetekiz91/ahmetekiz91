
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
    public class Per_Departman_TreeRepository : BaseRepository, IRepository.IPer_Departman_TreeRepository
    {

        public Per_Departman_TreeRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Per_Departman_Tree entity)
        {

            try
            {
                var query = "AddPer_Departman_Tree";
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

        public async Task<bool> DeleteAsync(object Per_Dep_Tree_Id)
        {
            try
            {
                var query = "DeletePer_Departman_Tree";

                var parameters = new DynamicParameters();
                parameters.Add("Per_Dep_Tree_Id", (Per_Dep_Tree_Id == null ? 0 : Convert.ToInt32(Per_Dep_Tree_Id)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Per_Departman_Tree>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Per_Departman_Tree>> GetAllAsync()
        {
            try
            {

                var query = "getPer_Departman_Tree";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Per_Departman_Tree>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Per_Departman_Tree> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Per_Departman_Tree WHERE Per_Dep_Tree_Id = @Per_Dep_Tree_Id";
                var parameters = new DynamicParameters();
                parameters.Add("Per_Dep_Tree_Id", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Per_Departman_Tree>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Per_Departman_Tree entity)
        {
            try
            {
                var query = "UpdatePer_Departman_TreeDetails";
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


