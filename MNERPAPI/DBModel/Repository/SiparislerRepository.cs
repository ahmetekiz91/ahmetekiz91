
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
    public class SiparislerRepository : BaseRepository, IRepository.ISiparislerRepository
    {

        public SiparislerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Siparisler entity)
        {

            try
            {
                var query = "AddSiparisler";
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

        public async Task<bool> DeleteAsync(object Sip_ID)
        {
            try
            {
                var query = "DeleteSiparisler";

                var parameters = new DynamicParameters();
                parameters.Add("Sip_ID", (Sip_ID == null ? 0 : Convert.ToInt32(Sip_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Siparisler>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Siparisler>> GetAllAsync()
        {
            try
            {

                var query = "getSiparisler";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Siparisler>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Siparisler> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Siparisler WHERE Sip_ID = @Sip_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Sip_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Siparisler>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Siparisler entity)
        {
            try
            {
                var query = "UpdateSiparislerDetails";
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


