
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
    public class MUH_KODLARIRepository : BaseRepository, IRepository.IMUH_KODLARIRepository
    {

        public MUH_KODLARIRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(MUH_KODLARI entity)
        {

            try
            {
                var query = "AddMUH_KODLARI";
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

        public async Task<bool> DeleteAsync(object KOD_ID)
        {
            try
            {
                var query = "DeleteMUH_KODLARI";

                var parameters = new DynamicParameters();
                parameters.Add("KOD_ID", (KOD_ID == null ? 0 : Convert.ToInt32(KOD_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<MUH_KODLARI>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<MUH_KODLARI>> GetAllAsync()
        {
            try
            {

                var query = "getMUH_KODLARI";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<MUH_KODLARI>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<MUH_KODLARI> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM MUH_KODLARI WHERE KOD_ID = @KOD_ID";
                var parameters = new DynamicParameters();
                parameters.Add("KOD_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<MUH_KODLARI>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(MUH_KODLARI entity)
        {
            try
            {
                var query = "UpdateMUH_KODLARIDetails";
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


