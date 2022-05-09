
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
    public class Uretim_EmirRepository : BaseRepository, IRepository.IUretim_EmirRepository
    {

        public Uretim_EmirRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Uretim_Emir entity)
        {

            try
            {
                var query = "AddUretim_Emir";
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

        public async Task<bool> DeleteAsync(object Ure_Emri_Id)
        {
            try
            {
                var query = "DeleteUretim_Emir";

                var parameters = new DynamicParameters();
                parameters.Add("Ure_Emri_Id", (Ure_Emri_Id == null ? 0 : Convert.ToInt32(Ure_Emri_Id)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Uretim_Emir>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Uretim_Emir>> GetAllAsync()
        {
            try
            {

                var query = "getUretim_Emir";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Uretim_Emir>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Uretim_Emir> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Uretim_Emir WHERE Ure_Emri_Id = @Ure_Emri_Id";
                var parameters = new DynamicParameters();
                parameters.Add("Ure_Emri_Id", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Uretim_Emir>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Uretim_Emir entity)
        {
            try
            {
                var query = "UpdateUretim_EmirDetails";
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


