
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
    public class IstasyonRepository : BaseRepository, IRepository.IIstasyonRepository
    {

        public IstasyonRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Istasyon entity)
        {

            try
            {
                var query = "AddIstasyon";
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

        public async Task<bool> DeleteAsync(object Istasyon_ID)
        {
            try
            {
                var query = "DeleteIstasyon";

                var parameters = new DynamicParameters();
                parameters.Add("Istasyon_ID", (Istasyon_ID == null ? 0 : Convert.ToInt32(Istasyon_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Istasyon>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Istasyon>> GetAllAsync()
        {
            try
            {

                var query = "getIstasyon";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Istasyon>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Istasyon> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Istasyon WHERE Istasyon_ID = @Istasyon_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Istasyon_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Istasyon>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Istasyon entity)
        {
            try
            {
                var query = "UpdateIstasyonDetails";
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


