
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
    public class Malz_ImagesRepository : BaseRepository, IRepository.IMalz_ImagesRepository
    {

        public Malz_ImagesRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Malz_Images entity)
        {

            try
            {
                var query = "AddMalz_Images";
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

        public async Task<bool> DeleteAsync(object Malz_Img_ID)
        {
            try
            {
                var query = "DeleteMalz_Images";

                var parameters = new DynamicParameters();
                parameters.Add("Malz_Img_ID", (Malz_Img_ID == null ? 0 : Convert.ToInt32(Malz_Img_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Malz_Images>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Malz_Images>> GetAllAsync()
        {
            try
            {

                var query = "getMalz_Images";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Malz_Images>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Malz_Images> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Malz_Images WHERE Malz_Img_ID = @Malz_Img_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Malz_Img_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Malz_Images>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Malz_Images entity)
        {
            try
            {
                var query = "UpdateMalz_ImagesDetails";
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


