
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
    public class Teslimat_TuruRepository : BaseRepository, IRepository.ITeslimat_TuruRepository
    {

        public Teslimat_TuruRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Teslimat_Turu entity)
        {

            try
            {
                var query = "AddTeslimat_Turu";
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

        public async Task<bool> DeleteAsync(object Tesl_ID)
        {
            try
            {
                var query = "DeleteTeslimat_Turu";

                var parameters = new DynamicParameters();
                parameters.Add("Tesl_ID", (Tesl_ID == null ? 0 : Convert.ToInt32(Tesl_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Teslimat_Turu>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Teslimat_Turu>> GetAllAsync()
        {
            try
            {

                var query = "getTeslimat_Turu";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Teslimat_Turu>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Teslimat_Turu> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Teslimat_Turu WHERE Tesl_ID = @Tesl_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Tesl_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Teslimat_Turu>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Teslimat_Turu entity)
        {
            try
            {
                var query = "UpdateTeslimat_TuruDetails";
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


