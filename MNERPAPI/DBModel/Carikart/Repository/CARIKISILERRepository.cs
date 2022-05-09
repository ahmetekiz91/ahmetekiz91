
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
    public class CARIKISILERRepository : BaseRepository, IRepository.ICARIKISILERRepository
    {

        public IUnitOfWork unitOfWork = null;
        private readonly IConfiguration _configuration;


        public CARIKISILERRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public CARIKISILERRepository(IUnitOfWork unitOfWork, IConfiguration configuration) : base(configuration)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Dispose()
        {

        }

        public async Task<bool> CreateAsync(CARIKISILER entity)
        {

            try
            {
                var query = "AddCARIKISILER";
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

        public async Task<bool> DeleteAsync(object Kisi_ID)
        {
            try
            {
                var query = "DeleteCARIKISILER";

                var parameters = new DynamicParameters();
                parameters.Add("Kisi_ID", (Kisi_ID == null ? 0 : Convert.ToInt32(Kisi_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<CARIKISILER>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<CARIKISILER>> GetAllAsync()
        {
            try
            {

                var query = "getCARIKISILER";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<CARIKISILER>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<CARIKISILER> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM CARIKISILER WHERE Kisi_ID = @Kisi_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Kisi_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<CARIKISILER>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(CARIKISILER entity)
        {
            try
            {
                var query = "UpdateCARIKISILERDetails";
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