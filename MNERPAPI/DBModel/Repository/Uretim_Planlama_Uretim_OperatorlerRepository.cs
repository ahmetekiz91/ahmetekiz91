
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
    public class Uretim_Planlama_Uretim_OperatorlerRepository : BaseRepository, IRepository.IUretim_Planlama_Uretim_OperatorlerRepository
    {

        public Uretim_Planlama_Uretim_OperatorlerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Uretim_Planlama_Uretim_Operatorler entity)
        {

            try
            {
                var query = "AddUretim_Planlama_Uretim_Operatorler";
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

        public async Task<bool> DeleteAsync(object Uretim_Plan_Uret_ID)
        {
            try
            {
                var query = "DeleteUretim_Planlama_Uretim_Operatorler";

                var parameters = new DynamicParameters();
                parameters.Add("Uretim_Plan_Uret_ID", (Uretim_Plan_Uret_ID == null ? 0 : Convert.ToInt32(Uretim_Plan_Uret_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Uretim_Planlama_Uretim_Operatorler>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Uretim_Planlama_Uretim_Operatorler>> GetAllAsync()
        {
            try
            {

                var query = "getUretim_Planlama_Uretim_Operatorler";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Uretim_Planlama_Uretim_Operatorler>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Uretim_Planlama_Uretim_Operatorler> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Uretim_Planlama_Uretim_Operatorler WHERE Uretim_Plan_Uret_ID = @Uretim_Plan_Uret_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Uretim_Plan_Uret_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Uretim_Planlama_Uretim_Operatorler>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Uretim_Planlama_Uretim_Operatorler entity)
        {
            try
            {
                var query = "UpdateUretim_Planlama_Uretim_OperatorlerDetails";
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


