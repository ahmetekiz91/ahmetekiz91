
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
    public class Fiili_Uretim_TuketimRepository : BaseRepository, IRepository.IFiili_Uretim_TuketimRepository
    {

        public Fiili_Uretim_TuketimRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Fiili_Uretim_Tuketim entity)
        {

            try
            {
                var query = "AddFiili_Uretim_Tuketim";
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

        public async Task<bool> DeleteAsync(object Fil_Uret_Tuk_ID)
        {
            try
            {
                var query = "DeleteFiili_Uretim_Tuketim";

                var parameters = new DynamicParameters();
                parameters.Add("Fil_Uret_Tuk_ID", (Fil_Uret_Tuk_ID == null ? 0 : Convert.ToInt32(Fil_Uret_Tuk_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Fiili_Uretim_Tuketim>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Fiili_Uretim_Tuketim>> GetAllAsync()
        {
            try
            {

                var query = "getFiili_Uretim_Tuketim";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Fiili_Uretim_Tuketim>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Fiili_Uretim_Tuketim> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Fiili_Uretim_Tuketim WHERE Fil_Uret_Tuk_ID = @Fil_Uret_Tuk_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Fil_Uret_Tuk_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Fiili_Uretim_Tuketim>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Fiili_Uretim_Tuketim entity)
        {
            try
            {
                var query = "UpdateFiili_Uretim_TuketimDetails";
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


