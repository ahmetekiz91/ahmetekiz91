
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
    public class Malz_KategorileriRepository : BaseRepository, IRepository.IMalz_KategorileriRepository
    {

        public Malz_KategorileriRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Malz_Kategorileri entity)
        {

            try
            {
                var query = "AddMalz_Kategorileri";
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

        public async Task<bool> DeleteAsync(object Malz_Kat_ID)
        {
            try
            {
                var query = "DeleteMalz_Kategorileri";

                var parameters = new DynamicParameters();
                parameters.Add("Malz_Kat_ID", (Malz_Kat_ID == null ? 0 : Convert.ToInt32(Malz_Kat_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Malz_Kategorileri>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Malz_Kategorileri>> GetAllAsync()
        {
            try
            {

                var query = "getMalz_Kategorileri";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Malz_Kategorileri>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Malz_Kategorileri> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Malz_Kategorileri WHERE Malz_Kat_ID = @Malz_Kat_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Malz_Kat_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Malz_Kategorileri>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Malz_Kategorileri entity)
        {
            try
            {
                var query = "UpdateMalz_KategorileriDetails";
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


