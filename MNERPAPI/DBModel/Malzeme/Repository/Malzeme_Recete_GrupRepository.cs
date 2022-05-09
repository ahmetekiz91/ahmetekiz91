
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
    public class Malzeme_Recete_GrupRepository : BaseRepository, IRepository.IMalzeme_Recete_GrupRepository
    {

        public Malzeme_Recete_GrupRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Malzeme_Recete_Grup entity)
        {

            try
            {
                var query = "AddMalzeme_Recete_Grup";
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

        public async Task<bool> DeleteAsync(object Mal_Rec_Grup_ID)
        {
            try
            {
                var query = "DeleteMalzeme_Recete_Grup";

                var parameters = new DynamicParameters();
                parameters.Add("Mal_Rec_Grup_ID", (Mal_Rec_Grup_ID == null ? 0 : Convert.ToInt32(Mal_Rec_Grup_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Malzeme_Recete_Grup>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Malzeme_Recete_Grup>> GetAllAsync()
        {
            try
            {

                var query = "getMalzeme_Recete_Grup";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Malzeme_Recete_Grup>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Malzeme_Recete_Grup> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Malzeme_Recete_Grup WHERE Mal_Rec_Grup_ID = @Mal_Rec_Grup_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Mal_Rec_Grup_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Malzeme_Recete_Grup>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Malzeme_Recete_Grup entity)
        {
            try
            {
                var query = "UpdateMalzeme_Recete_GrupDetails";
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


