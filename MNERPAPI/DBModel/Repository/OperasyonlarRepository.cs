
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
    public class OperasyonlarRepository : BaseRepository, IRepository.IOperasyonlarRepository
    {

        public OperasyonlarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Operasyonlar entity)
        {

            try
            {
                var query = "AddOperasyonlar";
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

        public async Task<bool> DeleteAsync(object Operasyon_ID)
        {
            try
            {
                var query = "DeleteOperasyonlar";

                var parameters = new DynamicParameters();
                parameters.Add("Operasyon_ID", (Operasyon_ID == null ? 0 : Convert.ToInt32(Operasyon_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Operasyonlar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Operasyonlar>> GetAllAsync()
        {
            try
            {

                var query = "getOperasyonlar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Operasyonlar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Operasyonlar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Operasyonlar WHERE Operasyon_ID = @Operasyon_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Operasyon_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Operasyonlar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Operasyonlar entity)
        {
            try
            {
                var query = "UpdateOperasyonlarDetails";
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


