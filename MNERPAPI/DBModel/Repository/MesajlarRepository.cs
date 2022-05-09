
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
    public class MesajlarRepository : BaseRepository, IRepository.IMesajlarRepository
    {

        public MesajlarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Mesajlar entity)
        {

            try
            {
                var query = "AddMesajlar";
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

        public async Task<bool> DeleteAsync(object MSJ_ID)
        {
            try
            {
                var query = "DeleteMesajlar";

                var parameters = new DynamicParameters();
                parameters.Add("MSJ_ID", (MSJ_ID == null ? 0 : Convert.ToInt32(MSJ_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Mesajlar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Mesajlar>> GetAllAsync()
        {
            try
            {

                var query = "getMesajlar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Mesajlar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Mesajlar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Mesajlar WHERE MSJ_ID = @MSJ_ID";
                var parameters = new DynamicParameters();
                parameters.Add("MSJ_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Mesajlar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Mesajlar entity)
        {
            try
            {
                var query = "UpdateMesajlarDetails";
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


