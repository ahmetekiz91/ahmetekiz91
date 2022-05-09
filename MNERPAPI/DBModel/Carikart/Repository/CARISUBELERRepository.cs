
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
    public class CARISUBELERRepository : BaseRepository, IRepository.ICARISUBELERRepository
    {

        public CARISUBELERRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(CARISUBELER entity)
        {

            try
            {
                var query = "AddCARISUBELER";
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

        public async Task<bool> DeleteAsync(object CARI_ADR_ID)
        {
            try
            {
                var query = "DeleteCARISUBELER";

                var parameters = new DynamicParameters();
                parameters.Add("CARI_ADR_ID", (CARI_ADR_ID == null ? 0 : Convert.ToInt32(CARI_ADR_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<CARISUBELER>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<CARISUBELER>> GetAllAsync()
        {
            try
            {

                var query = "getCARISUBELER";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<CARISUBELER>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<CARISUBELER> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM CARISUBELER WHERE CARI_ADR_ID = @CARI_ADR_ID";
                var parameters = new DynamicParameters();
                parameters.Add("CARI_ADR_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<CARISUBELER>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(CARISUBELER entity)
        {
            try
            {
                var query = "UpdateCARISUBELERDetails";
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


