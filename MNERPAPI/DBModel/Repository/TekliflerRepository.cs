
using Dapper;
using DBModel.Model;
using DBModel.Utility;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public class TekliflerRepository : BaseRepository, IRepository.ITekliflerRepository
    {

        public TekliflerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Teklifler entity)
        {

            try
            {
                var query = "AddTeklifler";
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
        //Lazım oldukça yazılacak
        public async Task<bool> CreateAsync(Teklifler entity,SqlConnection conn)
        {

            try
            {
                var query = "AddTeklifler";
                using (var connection = conn)
                {
                    var res = (await connection.ExecuteAsync(query, entity)); return true;
                }
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
        }

        public async Task<bool> DeleteAsync(object Teklif_ID)
        {
            try
            {
                var query = "DeleteTeklifler";

                var parameters = new DynamicParameters();
                parameters.Add("Teklif_ID", (Teklif_ID == null ? 0 : Convert.ToInt32(Teklif_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Teklifler>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Teklifler>> GetAllAsync()
        {
            try
            {

                var query = "getTeklifler";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Teklifler>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Teklifler> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Teklifler WHERE Teklif_ID = @Teklif_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Teklif_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Teklifler>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Teklifler entity)
        {
            try
            {
                var query = "UpdateTekliflerDetails";
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


