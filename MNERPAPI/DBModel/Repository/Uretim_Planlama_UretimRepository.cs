
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
    public class Uretim_Planlama_UretimRepository : BaseRepository, IRepository.IUretim_Planlama_UretimRepository
    {

        public Uretim_Planlama_UretimRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Uretim_Planlama_Uretim entity)
        {

            try
            {
                var query = "AddUretim_Planlama_Uretim";
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

        public async Task<bool> DeleteAsync(object Uret_Plan_Uret_ID)
        {
            try
            {
                var query = "DeleteUretim_Planlama_Uretim";

                var parameters = new DynamicParameters();
                parameters.Add("Uret_Plan_Uret_ID", (Uret_Plan_Uret_ID == null ? 0 : Convert.ToInt32(Uret_Plan_Uret_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Uretim_Planlama_Uretim>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Uretim_Planlama_Uretim>> GetAllAsync()
        {
            try
            {

                var query = "getUretim_Planlama_Uretim";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Uretim_Planlama_Uretim>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Uretim_Planlama_Uretim> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Uretim_Planlama_Uretim WHERE Uret_Plan_Uret_ID = @Uret_Plan_Uret_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Uret_Plan_Uret_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Uretim_Planlama_Uretim>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Uretim_Planlama_Uretim entity)
        {
            try
            {
                var query = "UpdateUretim_Planlama_UretimDetails";
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


