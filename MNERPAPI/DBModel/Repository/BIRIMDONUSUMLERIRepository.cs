
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
    public class BIRIMDONUSUMLERIRepository : BaseRepository, IRepository.IBIRIMDONUSUMLERIRepository
    {

        public BIRIMDONUSUMLERIRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(BIRIMDONUSUMLERI entity)
        {

            try
            {
                var query = "AddBIRIMDONUSUMLERI";
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

        public async Task<bool> DeleteAsync(object Birim_Don_ID)
        {
            try
            {
                var query = "DeleteBIRIMDONUSUMLERI";

                var parameters = new DynamicParameters();
                parameters.Add("Birim_Don_ID", (Birim_Don_ID == null ? 0 : Convert.ToInt32(Birim_Don_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<BIRIMDONUSUMLERI>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<BIRIMDONUSUMLERI>> GetAllAsync()
        {
            try
            {

                var query = "getBIRIMDONUSUMLERI";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<BIRIMDONUSUMLERI>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BIRIMDONUSUMLERI> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM BIRIMDONUSUMLERI WHERE Birim_Don_ID = @Birim_Don_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Birim_Don_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<BIRIMDONUSUMLERI>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(BIRIMDONUSUMLERI entity)
        {
            try
            {
                var query = "UpdateBIRIMDONUSUMLERIDetails";
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


