
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
    public class Malzeme_Recete_AttributeRepository : BaseRepository, IRepository.IMalzeme_Recete_AttributeRepository
    {

        public Malzeme_Recete_AttributeRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Malzeme_Recete_Attribute entity)
        {

            try
            {
                var query = "AddMalzeme_Recete_Attribute";
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

        public async Task<bool> DeleteAsync(object Malz_Recete_Att_ID)
        {
            try
            {
                var query = "DeleteMalzeme_Recete_Attribute";

                var parameters = new DynamicParameters();
                parameters.Add("Malz_Recete_Att_ID", (Malz_Recete_Att_ID == null ? 0 : Convert.ToInt32(Malz_Recete_Att_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Malzeme_Recete_Attribute>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Malzeme_Recete_Attribute>> GetAllAsync()
        {
            try
            {

                var query = "getMalzeme_Recete_Attribute";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Malzeme_Recete_Attribute>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Malzeme_Recete_Attribute> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Malzeme_Recete_Attribute WHERE Malz_Recete_Att_ID = @Malz_Recete_Att_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Malz_Recete_Att_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Malzeme_Recete_Attribute>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Malzeme_Recete_Attribute entity)
        {
            try
            {
                var query = "UpdateMalzeme_Recete_AttributeDetails";
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


