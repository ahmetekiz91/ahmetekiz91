
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
    public class DepartmanlarRepository : BaseRepository, IRepository.IDepartmanlarRepository
    {

        public DepartmanlarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Departmanlar entity)
        {

            try
            {
                var query = "AddDepartmanlar";
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

        public async Task<bool> DeleteAsync(object Depart_ID)
        {
            try
            {
                var query = "DeleteDepartmanlar";

                var parameters = new DynamicParameters();
                parameters.Add("Depart_ID", (Depart_ID == null ? 0 : Convert.ToInt32(Depart_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Departmanlar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Departmanlar>> GetAllAsync()
        {
            try
            {

                var query = "getDepartmanlar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Departmanlar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Departmanlar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Departmanlar WHERE Depart_ID = @Depart_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Depart_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Departmanlar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Departmanlar entity)
        {
            try
            {
                var query = "UpdateDepartmanlarDetails";
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


