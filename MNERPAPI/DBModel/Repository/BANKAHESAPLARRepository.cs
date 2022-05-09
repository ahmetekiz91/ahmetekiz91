
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

    public class BANKAHESAPLARRepository : BaseRepository, IRepository.IBANKAHESAPLARRepository
    {


        public BANKAHESAPLARRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<bool> CreateAsync(BANKAHESAPLAR entity)
        {

            try
            {
                var query = "AddBANKAHESAPLAR";
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

        public async Task<bool> DeleteAsync(object HESAP_ID)
        {
            try
            {
                var query = "DeleteBANKAHESAPLAR";

                var parameters = new DynamicParameters();
                parameters.Add("HESAP_ID", (HESAP_ID == null ? 0 : Convert.ToInt32(HESAP_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<BANKAHESAPLAR>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<BANKAHESAPLAR>> GetAllAsync()
        {
            try
            {

                var query = "getBANKAHESAPLAR";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<BANKAHESAPLAR>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<BANKAHESAPLAR> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM BANKAHESAPLAR WHERE HESAP_ID = @HESAP_ID";
                var parameters = new DynamicParameters();
                parameters.Add("HESAP_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<BANKAHESAPLAR>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(BANKAHESAPLAR entity)
        {
            try
            {
                var query = "UpdateBANKAHESAPLARDetails";
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


