
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
    public class Fiili_UretimRepository : BaseRepository, IRepository.IFiili_UretimRepository
    {

        public Fiili_UretimRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Fiili_Uretim entity)
        {

            try
            {
                var query = "AddFiili_Uretim";
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

        public async Task<bool> DeleteAsync(object Fiil_Uret_ID)
        {
            try
            {
                var query = "DeleteFiili_Uretim";

                var parameters = new DynamicParameters();
                parameters.Add("Fiil_Uret_ID", (Fiil_Uret_ID == null ? 0 : Convert.ToInt32(Fiil_Uret_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Fiili_Uretim>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Fiili_Uretim>> GetAllAsync()
        {
            try
            {

                var query = "getFiili_Uretim";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Fiili_Uretim>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Fiili_Uretim> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Fiili_Uretim WHERE Fiil_Uret_ID = @Fiil_Uret_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Fiil_Uret_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Fiili_Uretim>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Fiili_Uretim entity)
        {
            try
            {
                var query = "UpdateFiili_UretimDetails";
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


