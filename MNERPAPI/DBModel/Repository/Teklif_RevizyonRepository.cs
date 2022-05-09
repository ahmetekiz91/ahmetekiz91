
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
    public class Teklif_RevizyonRepository : BaseRepository, IRepository.ITeklif_RevizyonRepository
    {

        public Teklif_RevizyonRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Teklif_Revizyon entity)
        {

            try
            {
                var query = "AddTeklif_Revizyon";
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

        public async Task<bool> DeleteAsync(object Tek_Rev_ID)
        {
            try
            {
                var query = "DeleteTeklif_Revizyon";

                var parameters = new DynamicParameters();
                parameters.Add("Tek_Rev_ID", (Tek_Rev_ID == null ? 0 : Convert.ToInt32(Tek_Rev_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Teklif_Revizyon>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Teklif_Revizyon>> GetAllAsync()
        {
            try
            {

                var query = "getTeklif_Revizyon";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Teklif_Revizyon>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Teklif_Revizyon> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Teklif_Revizyon WHERE Tek_Rev_ID = @Tek_Rev_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Tek_Rev_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Teklif_Revizyon>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Teklif_Revizyon entity)
        {
            try
            {
                var query = "UpdateTeklif_RevizyonDetails";
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


