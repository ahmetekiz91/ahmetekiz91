
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
    public class MalzemeRepository : BaseRepository, IRepository.IMalzemeRepository
    {

        public MalzemeRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Malzeme entity)
        {

            try
            {
                var query = "AddMalzeme";
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

        public async Task<bool> DeleteAsync(object MALZ_ID)
        {
            try
            {
                var query = "DeleteMalzeme";

                var parameters = new DynamicParameters();
                parameters.Add("MALZ_ID", (MALZ_ID == null ? 0 : Convert.ToInt32(MALZ_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Malzeme>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Malzeme>> GetAllAsync()
        {
            try
            {

                var query = "getMalzeme";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Malzeme>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Malzeme> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Malzeme WHERE MALZ_ID = @MALZ_ID";
                var parameters = new DynamicParameters();
                parameters.Add("MALZ_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Malzeme>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Malzeme entity)
        {
            try
            {
                var query = "UpdateMalzemeDetails";
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


