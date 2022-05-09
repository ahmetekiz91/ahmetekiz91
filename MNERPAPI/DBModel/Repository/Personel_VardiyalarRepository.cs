
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
    public class Personel_VardiyalarRepository : BaseRepository, IRepository.IPersonel_VardiyalarRepository
    {

        public Personel_VardiyalarRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Personel_Vardiyalar entity)
        {

            try
            {
                var query = "AddPersonel_Vardiyalar";
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

        public async Task<bool> DeleteAsync(object Per_Var_Id)
        {
            try
            {
                var query = "DeletePersonel_Vardiyalar";

                var parameters = new DynamicParameters();
                parameters.Add("Per_Var_Id", (Per_Var_Id == null ? 0 : Convert.ToInt32(Per_Var_Id)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Personel_Vardiyalar>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Personel_Vardiyalar>> GetAllAsync()
        {
            try
            {

                var query = "getPersonel_Vardiyalar";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Personel_Vardiyalar>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Personel_Vardiyalar> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Personel_Vardiyalar WHERE Per_Var_Id = @Per_Var_Id";
                var parameters = new DynamicParameters();
                parameters.Add("Per_Var_Id", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Personel_Vardiyalar>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Personel_Vardiyalar entity)
        {
            try
            {
                var query = "UpdatePersonel_VardiyalarDetails";
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


