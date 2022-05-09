
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
    public class Mal_AlimRepository : BaseRepository, IRepository.IMal_AlimRepository
    {

        public Mal_AlimRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Mal_Alim entity)
        {

            try
            {
                var query = "AddMal_Alim";
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

        public async Task<bool> DeleteAsync(object Mal_Alim_ID)
        {
            try
            {
                var query = "DeleteMal_Alim";

                var parameters = new DynamicParameters();
                parameters.Add("Mal_Alim_ID", (Mal_Alim_ID == null ? 0 : Convert.ToInt32(Mal_Alim_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Mal_Alim>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Mal_Alim>> GetAllAsync()
        {
            try
            {

                var query = "getMal_Alim";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Mal_Alim>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Mal_Alim> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Mal_Alim WHERE Mal_Alim_ID = @Mal_Alim_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Mal_Alim_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Mal_Alim>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Mal_Alim entity)
        {
            try
            {
                var query = "UpdateMal_AlimDetails";
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


