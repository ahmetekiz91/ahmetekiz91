
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
    public class Doviz_KurlariRepository : BaseRepository, IRepository.IDoviz_KurlariRepository
    {

        public Doviz_KurlariRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Doviz_Kurlari entity)
        {

            try
            {
                var query = "AddDoviz_Kurlari";
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

        public async Task<bool> DeleteAsync(object Doviz_Kur_ID)
        {
            try
            {
                var query = "DeleteDoviz_Kurlari";

                var parameters = new DynamicParameters();
                parameters.Add("Doviz_Kur_ID", (Doviz_Kur_ID == null ? 0 : Convert.ToInt32(Doviz_Kur_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Doviz_Kurlari>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Doviz_Kurlari>> GetAllAsync()
        {
            try
            {

                var query = "getDoviz_Kurlari";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Doviz_Kurlari>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Doviz_Kurlari> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Doviz_Kurlari WHERE Doviz_Kur_ID = @Doviz_Kur_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Doviz_Kur_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Doviz_Kurlari>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Doviz_Kurlari entity)
        {
            try
            {
                var query = "UpdateDoviz_KurlariDetails";
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


