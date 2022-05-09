
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
    public class Duy_DetayRepository : BaseRepository, IRepository.IDuy_DetayRepository
    {

        public Duy_DetayRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Duy_Detay entity)
        {

            try
            {
                var query = "AddDuy_Detay";
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

        public async Task<bool> DeleteAsync(object DDET_ID)
        {
            try
            {
                var query = "DeleteDuy_Detay";

                var parameters = new DynamicParameters();
                parameters.Add("DDET_ID", (DDET_ID == null ? 0 : Convert.ToInt32(DDET_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Duy_Detay>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Duy_Detay>> GetAllAsync()
        {
            try
            {

                var query = "getDuy_Detay";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Duy_Detay>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Duy_Detay> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Duy_Detay WHERE DDET_ID = @DDET_ID";
                var parameters = new DynamicParameters();
                parameters.Add("DDET_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Duy_Detay>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Duy_Detay entity)
        {
            try
            {
                var query = "UpdateDuy_DetayDetails";
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


