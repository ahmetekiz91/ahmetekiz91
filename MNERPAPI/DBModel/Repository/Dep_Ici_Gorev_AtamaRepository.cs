
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
    public class Dep_Ici_Gorev_AtamaRepository : BaseRepository, IRepository.IDep_Ici_Gorev_AtamaRepository
    {

        public Dep_Ici_Gorev_AtamaRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Dep_Ici_Gorev_Atama entity)
        {

            try
            {
                var query = "AddDep_Ici_Gorev_Atama";
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

        public async Task<bool> DeleteAsync(object Gorev_Atanan_Dep_ID)
        {
            try
            {
                var query = "DeleteDep_Ici_Gorev_Atama";

                var parameters = new DynamicParameters();
                parameters.Add("Gorev_Atanan_Dep_ID", (Gorev_Atanan_Dep_ID == null ? 0 : Convert.ToInt32(Gorev_Atanan_Dep_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Dep_Ici_Gorev_Atama>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Dep_Ici_Gorev_Atama>> GetAllAsync()
        {
            try
            {

                var query = "getDep_Ici_Gorev_Atama";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Dep_Ici_Gorev_Atama>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Dep_Ici_Gorev_Atama> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Dep_Ici_Gorev_Atama WHERE Gorev_Atanan_Dep_ID = @Gorev_Atanan_Dep_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Gorev_Atanan_Dep_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Dep_Ici_Gorev_Atama>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Dep_Ici_Gorev_Atama entity)
        {
            try
            {
                var query = "UpdateDep_Ici_Gorev_AtamaDetails";
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


