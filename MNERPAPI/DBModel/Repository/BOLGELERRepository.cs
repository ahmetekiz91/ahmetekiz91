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
    public class BOLGELERRepository : BaseRepository, IRepository.IBOLGELERRepository
    {

        public BOLGELERRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(BOLGELER entity)
        {

            try
            {
                var query = "AddBOLGELER";
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

        public async Task<bool> DeleteAsync(object Bolge_ID)
        {
            try
            {
                var query = "DeleteBOLGELER";

                var parameters = new DynamicParameters();
                parameters.Add("Bolge_ID", (Bolge_ID == null ? 0 : Convert.ToInt32(Bolge_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<BOLGELER>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<BOLGELER>> GetAllAsync()
        {
            try
            {

                var query = "getBOLGELER";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<BOLGELER>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BOLGELER> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM BOLGELER WHERE Bolge_ID = @Bolge_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Bolge_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<BOLGELER>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(BOLGELER entity)
        {
            try
            {
                var query = "UpdateBOLGELERDetails";
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


