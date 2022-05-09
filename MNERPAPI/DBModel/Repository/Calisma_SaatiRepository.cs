
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
    public class Calisma_SaatiRepository : BaseRepository, IRepository.ICalisma_SaatiRepository
    {

        public Calisma_SaatiRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Calisma_Saati entity)
        {

            try
            {
                var query = "AddCalisma_Saati";
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

        public async Task<bool> DeleteAsync(object Calis_Saati_Id)
        {
            try
            {
                var query = "DeleteCalisma_Saati";

                var parameters = new DynamicParameters();
                parameters.Add("Calis_Saati_Id", (Calis_Saati_Id == null ? 0 : Convert.ToInt32(Calis_Saati_Id)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Calisma_Saati>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Calisma_Saati>> GetAllAsync()
        {
            try
            {

                var query = "getCalisma_Saati";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Calisma_Saati>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Calisma_Saati> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Calisma_Saati WHERE Calis_Saati_Id = @Calis_Saati_Id";
                var parameters = new DynamicParameters();
                parameters.Add("Calis_Saati_Id", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Calisma_Saati>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Calisma_Saati entity)
        {
            try
            {
                var query = "UpdateCalisma_SaatiDetails";
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


