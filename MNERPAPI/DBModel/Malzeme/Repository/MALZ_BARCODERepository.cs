
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
    public class MALZ_BARCODERepository : BaseRepository, IRepository.IMALZ_BARCODERepository
    {

        public MALZ_BARCODERepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MALZ_BARCODE entity)
        {

            try
            {
                var query = "AddMALZ_BARCODE";
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

        public async Task<bool> DeleteAsync(object MALZ_BAR_ID)
        {
            try
            {
                var query = "DeleteMALZ_BARCODE";

                var parameters = new DynamicParameters();
                parameters.Add("MALZ_BAR_ID", (MALZ_BAR_ID == null ? 0 : Convert.ToInt32(MALZ_BAR_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MALZ_BARCODE>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MALZ_BARCODE>> GetAllAsync()
        {
            try
            {

                var query = "getMALZ_BARCODE";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MALZ_BARCODE>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MALZ_BARCODE> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MALZ_BARCODE WHERE MALZ_BAR_ID = @MALZ_BAR_ID";
                var parameters = new DynamicParameters();
                parameters.Add("MALZ_BAR_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MALZ_BARCODE>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MALZ_BARCODE entity)
        {
            try
            {
                var query = "UpdateMALZ_BARCODEDetails";
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


