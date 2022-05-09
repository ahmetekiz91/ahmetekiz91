
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
    public class Malzeme_AttributeRepository : BaseRepository, IRepository.IMalzeme_AttributeRepository
    {

        public Malzeme_AttributeRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Malzeme_Attribute entity)
        {

            try
            {
                var query = "AddMalzeme_Attribute";
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

        public async Task<bool> DeleteAsync(object ID)
        {
            try
            {
                var query = "DeleteMalzeme_Attribute";

                var parameters = new DynamicParameters();
                parameters.Add("ID", (ID == null ? 0 : Convert.ToInt32(ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Malzeme_Attribute>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Malzeme_Attribute>> GetAllAsync()
        {
            try
            {

                var query = "getMalzeme_Attribute";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Malzeme_Attribute>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Malzeme_Attribute> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Malzeme_Attribute WHERE ID = @ID";
                var parameters = new DynamicParameters();
                parameters.Add("ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Malzeme_Attribute>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Malzeme_Attribute entity)
        {
            try
            {
                var query = "UpdateMalzeme_AttributeDetails";
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


