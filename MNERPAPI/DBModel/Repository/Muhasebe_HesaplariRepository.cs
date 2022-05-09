
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
    public class Muhasebe_HesaplariRepository : BaseRepository, IRepository.IMuhasebe_HesaplariRepository
    {

        public Muhasebe_HesaplariRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Muhasebe_Hesaplari entity)
        {

            try
            {
                var query = "AddMuhasebe_Hesaplari";
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

        public async Task<bool> DeleteAsync(object MUH_HSP_ID)
        {
            try
            {
                var query = "DeleteMuhasebe_Hesaplari";

                var parameters = new DynamicParameters();
                parameters.Add("MUH_HSP_ID", (MUH_HSP_ID == null ? 0 : Convert.ToInt32(MUH_HSP_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Muhasebe_Hesaplari>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Muhasebe_Hesaplari>> GetAllAsync()
        {
            try
            {

                var query = "getMuhasebe_Hesaplari";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Muhasebe_Hesaplari>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Muhasebe_Hesaplari> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Muhasebe_Hesaplari WHERE MUH_HSP_ID = @MUH_HSP_ID";
                var parameters = new DynamicParameters();
                parameters.Add("MUH_HSP_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Muhasebe_Hesaplari>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Muhasebe_Hesaplari entity)
        {
            try
            {
                var query = "UpdateMuhasebe_HesaplariDetails";
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


