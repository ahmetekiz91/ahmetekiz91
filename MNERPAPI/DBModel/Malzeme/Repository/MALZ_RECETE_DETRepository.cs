
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
    public class MALZ_RECETE_DETRepository : BaseRepository, IRepository.IMALZ_RECETE_DETRepository
    {

        public MALZ_RECETE_DETRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MALZ_RECETE_DET entity)
        {

            try
            {
                var query = "AddMALZ_RECETE_DET";
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

        public async Task<bool> DeleteAsync(object MALZ_REC_DET_ID)
        {
            try
            {
                var query = "DeleteMALZ_RECETE_DET";

                var parameters = new DynamicParameters();
                parameters.Add("MALZ_REC_DET_ID", (MALZ_REC_DET_ID == null ? 0 : Convert.ToInt32(MALZ_REC_DET_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MALZ_RECETE_DET>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MALZ_RECETE_DET>> GetAllAsync()
        {
            try
            {

                var query = "getMALZ_RECETE_DET";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MALZ_RECETE_DET>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MALZ_RECETE_DET> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MALZ_RECETE_DET WHERE MALZ_REC_DET_ID = @MALZ_REC_DET_ID";
                var parameters = new DynamicParameters();
                parameters.Add("MALZ_REC_DET_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MALZ_RECETE_DET>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MALZ_RECETE_DET entity)
        {
            try
            {
                var query = "UpdateMALZ_RECETE_DETDetails";
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


