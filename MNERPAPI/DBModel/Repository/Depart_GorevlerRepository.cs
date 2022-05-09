
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
    public class Depart_GorevlerRepository : BaseRepository, IRepository.IDepart_GorevlerRepository
    {

        public Depart_GorevlerRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Depart_Gorevler entity)
        {

            try
            {
                var query = "AddDepart_Gorevler";
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

        public async Task<bool> DeleteAsync(object Gor_Dep_ID)
        {
            try
            {
                var query = "DeleteDepart_Gorevler";

                var parameters = new DynamicParameters();
                parameters.Add("Gor_Dep_ID", (Gor_Dep_ID == null ? 0 : Convert.ToInt32(Gor_Dep_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Depart_Gorevler>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Depart_Gorevler>> GetAllAsync()
        {
            try
            {

                var query = "getDepart_Gorevler";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Depart_Gorevler>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Depart_Gorevler> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Depart_Gorevler WHERE Gor_Dep_ID = @Gor_Dep_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Gor_Dep_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Depart_Gorevler>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Depart_Gorevler entity)
        {
            try
            {
                var query = "UpdateDepart_GorevlerDetails";
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


