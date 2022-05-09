
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
    public class Teklif_Revizyon_Kalem_ParamsRepository : BaseRepository, IRepository.ITeklif_Revizyon_Kalem_ParamsRepository
    {

        public Teklif_Revizyon_Kalem_ParamsRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Teklif_Revizyon_Kalem_Params entity)
        {

            try
            {
                var query = "AddTeklif_Revizyon_Kalem_Params";
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

        public async Task<bool> DeleteAsync(object Teklif_Rev_Kal_Par_ID)
        {
            try
            {
                var query = "DeleteTeklif_Revizyon_Kalem_Params";

                var parameters = new DynamicParameters();
                parameters.Add("Teklif_Rev_Kal_Par_ID", (Teklif_Rev_Kal_Par_ID == null ? 0 : Convert.ToInt32(Teklif_Rev_Kal_Par_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Teklif_Revizyon_Kalem_Params>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Teklif_Revizyon_Kalem_Params>> GetAllAsync()
        {
            try
            {

                var query = "getTeklif_Revizyon_Kalem_Params";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Teklif_Revizyon_Kalem_Params>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Teklif_Revizyon_Kalem_Params> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Teklif_Revizyon_Kalem_Params WHERE Teklif_Rev_Kal_Par_ID = @Teklif_Rev_Kal_Par_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Teklif_Rev_Kal_Par_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Teklif_Revizyon_Kalem_Params>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Teklif_Revizyon_Kalem_Params entity)
        {
            try
            {
                var query = "UpdateTeklif_Revizyon_Kalem_ParamsDetails";
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


