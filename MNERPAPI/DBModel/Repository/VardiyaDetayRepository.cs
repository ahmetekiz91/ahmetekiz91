
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
    public class VardiyaDetayRepository : BaseRepository, IRepository.IVardiyaDetayRepository
    {

        public VardiyaDetayRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(VardiyaDetay entity)
        {

            try
            {
                var query = "AddVardiyaDetay";
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

        public async Task<bool> DeleteAsync(object Var_Det_ID)
        {
            try
            {
                var query = "DeleteVardiyaDetay";

                var parameters = new DynamicParameters();
                parameters.Add("Var_Det_ID", (Var_Det_ID == null ? 0 : Convert.ToInt32(Var_Det_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<VardiyaDetay>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<VardiyaDetay>> GetAllAsync()
        {
            try
            {

                var query = "getVardiyaDetay";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<VardiyaDetay>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<VardiyaDetay> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM VardiyaDetay WHERE Var_Det_ID = @Var_Det_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Var_Det_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<VardiyaDetay>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(VardiyaDetay entity)
        {
            try
            {
                var query = "UpdateVardiyaDetayDetails";
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


