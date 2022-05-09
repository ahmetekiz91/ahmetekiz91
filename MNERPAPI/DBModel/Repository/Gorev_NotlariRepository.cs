
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
    public class Gorev_NotlariRepository : BaseRepository, IRepository.IGorev_NotlariRepository
    {

        public Gorev_NotlariRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Gorev_Notlari entity)
        {

            try
            {
                var query = "AddGorev_Notlari";
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

        public async Task<bool> DeleteAsync(object Grv_Not_Id)
        {
            try
            {
                var query = "DeleteGorev_Notlari";

                var parameters = new DynamicParameters();
                parameters.Add("Grv_Not_Id", (Grv_Not_Id == null ? 0 : Convert.ToInt32(Grv_Not_Id)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Gorev_Notlari>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Gorev_Notlari>> GetAllAsync()
        {
            try
            {

                var query = "getGorev_Notlari";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Gorev_Notlari>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Gorev_Notlari> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Gorev_Notlari WHERE Grv_Not_Id = @Grv_Not_Id";
                var parameters = new DynamicParameters();
                parameters.Add("Grv_Not_Id", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Gorev_Notlari>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Gorev_Notlari entity)
        {
            try
            {
                var query = "UpdateGorev_NotlariDetails";
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


