
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
    public class Vardiya_KisilerRepository : BaseRepository, IRepository.IVardiya_KisilerRepository
    {

        public Vardiya_KisilerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Vardiya_Kisiler entity)
        {

            try
            {
                var query = "AddVardiya_Kisiler";
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

        public async Task<bool> DeleteAsync(object Vardiya_Kisi_ID)
        {
            try
            {
                var query = "DeleteVardiya_Kisiler";

                var parameters = new DynamicParameters();
                parameters.Add("Vardiya_Kisi_ID", (Vardiya_Kisi_ID == null ? 0 : Convert.ToInt32(Vardiya_Kisi_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Vardiya_Kisiler>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Vardiya_Kisiler>> GetAllAsync()
        {
            try
            {

                var query = "getVardiya_Kisiler";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Vardiya_Kisiler>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Vardiya_Kisiler> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Vardiya_Kisiler WHERE Vardiya_Kisi_ID = @Vardiya_Kisi_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Vardiya_Kisi_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Vardiya_Kisiler>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Vardiya_Kisiler entity)
        {
            try
            {
                var query = "UpdateVardiya_KisilerDetails";
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


