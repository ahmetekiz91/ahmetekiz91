
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
    public class Personel_Aile_BilgileriRepository : BaseRepository, IRepository.IPersonel_Aile_BilgileriRepository
    {

        public Personel_Aile_BilgileriRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Personel_Aile_Bilgileri entity)
        {

            try
            {
                var query = "AddPersonel_Aile_Bilgileri";
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

        public async Task<bool> DeleteAsync(object Per_Aile_Bilg_ID)
        {
            try
            {
                var query = "DeletePersonel_Aile_Bilgileri";

                var parameters = new DynamicParameters();
                parameters.Add("Per_Aile_Bilg_ID", (Per_Aile_Bilg_ID == null ? 0 : Convert.ToInt32(Per_Aile_Bilg_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Personel_Aile_Bilgileri>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Personel_Aile_Bilgileri>> GetAllAsync()
        {
            try
            {

                var query = "getPersonel_Aile_Bilgileri";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Personel_Aile_Bilgileri>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Personel_Aile_Bilgileri> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Personel_Aile_Bilgileri WHERE Per_Aile_Bilg_ID = @Per_Aile_Bilg_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Per_Aile_Bilg_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Personel_Aile_Bilgileri>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Personel_Aile_Bilgileri entity)
        {
            try
            {
                var query = "UpdatePersonel_Aile_BilgileriDetails";
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


