
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
    public class Talep_Detay_ParamsRepository : BaseRepository, IRepository.ITalep_Detay_ParamsRepository
    {

        public Talep_Detay_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Talep_Detay_Params entity)
        {

            try
            {
                var query = "AddTalep_Detay_Params";
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

        public async Task<bool> DeleteAsync(object TLP_DET_PAR_ID)
        {
            try
            {
                var query = "DeleteTalep_Detay_Params";

                var parameters = new DynamicParameters();
                parameters.Add("TLP_DET_PAR_ID", (TLP_DET_PAR_ID == null ? 0 : Convert.ToInt32(TLP_DET_PAR_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Talep_Detay_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Talep_Detay_Params>> GetAllAsync()
        {
            try
            {

                var query = "getTalep_Detay_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Talep_Detay_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Talep_Detay_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Talep_Detay_Params WHERE TLP_DET_PAR_ID = @TLP_DET_PAR_ID";
                var parameters = new DynamicParameters();
                parameters.Add("TLP_DET_PAR_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Talep_Detay_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Talep_Detay_Params entity)
        {
            try
            {
                var query = "UpdateTalep_Detay_ParamsDetails";
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


