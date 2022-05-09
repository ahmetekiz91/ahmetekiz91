
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
    public class Fis_TurleriRepository : BaseRepository, IRepository.IFis_TurleriRepository
    {

        public Fis_TurleriRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Fis_Turleri entity)
        {

            try
            {
                var query = "AddFis_Turleri";
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

        public async Task<bool> DeleteAsync(object Tur_Id)
        {
            try
            {
                var query = "DeleteFis_Turleri";

                var parameters = new DynamicParameters();
                parameters.Add("Tur_Id", (Tur_Id == null ? 0 : Convert.ToInt32(Tur_Id)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Fis_Turleri>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Fis_Turleri>> GetAllAsync()
        {
            try
            {

                var query = "getFis_Turleri";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Fis_Turleri>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Fis_Turleri> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Fis_Turleri WHERE Tur_Id = @Tur_Id";
                var parameters = new DynamicParameters();
                parameters.Add("Tur_Id", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Fis_Turleri>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Fis_Turleri entity)
        {
            try
            {
                var query = "UpdateFis_TurleriDetails";
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


