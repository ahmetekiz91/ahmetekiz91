
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
    public class Makina_MalzemeRepository : BaseRepository, IRepository.IMakina_MalzemeRepository
    {

        public Makina_MalzemeRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Makina_Malzeme entity)
        {

            try
            {
                var query = "AddMakina_Malzeme";
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

        public async Task<bool> DeleteAsync(object Malz_ID)
        {
            try
            {
                var query = "DeleteMakina_Malzeme";

                var parameters = new DynamicParameters();
                parameters.Add("Malz_ID", (Malz_ID == null ? 0 : Convert.ToInt32(Malz_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Makina_Malzeme>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Makina_Malzeme>> GetAllAsync()
        {
            try
            {

                var query = "getMakina_Malzeme";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Makina_Malzeme>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Makina_Malzeme> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Makina_Malzeme WHERE Malz_ID = @Malz_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Malz_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Makina_Malzeme>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Makina_Malzeme entity)
        {
            try
            {
                var query = "UpdateMakina_MalzemeDetails";
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


