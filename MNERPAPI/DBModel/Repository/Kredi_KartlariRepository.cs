
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
    public class Kredi_KartlariRepository : BaseRepository, IRepository.IKredi_KartlariRepository
    {

        public Kredi_KartlariRepository(IConfiguration configuration) :
            base(configuration)
        {
        }

        public async Task<bool> CreateAsync(Kredi_Kartlari entity)
        {

            try
            {
                var query = "AddKredi_Kartlari";
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

        public async Task<bool> DeleteAsync(object Kart_ID)
        {
            try
            {
                var query = "DeleteKredi_Kartlari";

                var parameters = new DynamicParameters();
                parameters.Add("Kart_ID", (Kart_ID == null ? 0 : Convert.ToInt32(Kart_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Kredi_Kartlari>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Kredi_Kartlari>> GetAllAsync()
        {
            try
            {

                var query = "getKredi_Kartlari";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Kredi_Kartlari>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Kredi_Kartlari> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Kredi_Kartlari WHERE Kart_ID = @Kart_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Kart_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Kredi_Kartlari>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Kredi_Kartlari entity)
        {
            try
            {
                var query = "UpdateKredi_KartlariDetails";
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


