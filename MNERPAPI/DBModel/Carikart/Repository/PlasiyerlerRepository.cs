
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
    public class PlasiyerlerRepository : BaseRepository, IDisposable, IRepository.IPlasiyerlerRepository
    {
        public IUnitOfWork unitOfWork = null;
        private readonly IConfiguration _configuration;


        public PlasiyerlerRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public PlasiyerlerRepository(IUnitOfWork unitOfWork, IConfiguration configuration) : base(configuration)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Dispose()
        {

        }
        public async Task<bool> CreateAsync(Plasiyerler entity)
        {

            try
            {
                int f = 0;
                var query = "AddPlasiyerler";
                var parameters = new DynamicParameters();
         
                parameters.Add("@USR_ID", entity.USR_ID, DbType.Int32);
                parameters.Add("@CDATE", entity.CDATE,DbType.DateTime);
                parameters.Add("@CUSR_ID", entity.CUSR_ID, DbType.Int32);
                parameters.Add("@UDATE", entity.UDATE, DbType.DateTime);
                parameters.Add("@PLADI", entity.PLADI, DbType.String);
                parameters.Add("@PLSOYADI", entity.PLSOYADI, DbType.String);
                parameters.Add("@PLTEL", entity.PLTEL, DbType.String);
                parameters.Add("@PLEMAIL", entity.PLEMAIL, DbType.String);


                f = await unitOfWork.Connection.ExecuteAsync(query, parameters, unitOfWork.Transaction,
          commandType: CommandType.StoredProcedure);
                if (f > 0) return true;
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
            return false;
        }

        public async Task<bool> DeleteAsync(object PLA_ID)
        {
            try
            {
                int f = 0;
                var query = "DeletePlasiyerler";

                var parameters = new DynamicParameters();
                parameters.Add("PLA_ID", (PLA_ID == null ? 0 : Convert.ToInt32(PLA_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<Plasiyerler>(query, parameters,
                        commandType: CommandType.StoredProcedure));
                    return true;
                }
            }
            catch (Exception ex)
            {
               
            }
            return false;
        }

        public async Task<List<Plasiyerler>> GetAllAsync()
        {
            List<Plasiyerler> list = new List<Plasiyerler>();
            try
            {


                var query = "getAllPlasiyerler";

                var parameters = new DynamicParameters();
                list = (await unitOfWork.Connection.QueryAsync<Plasiyerler>(query, parameters, unitOfWork.Transaction)).ToList();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return list;
        }

        public async Task<Plasiyerler> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM Plasiyerler WHERE PLA_ID = @PLA_ID";
                var parameters = new DynamicParameters();
                parameters.Add("PLA_ID", id, DbType.Int32);
               

                using (var connection = CreateConnection())
                {
                    return (await unitOfWork.Connection.QueryAsync<Plasiyerler>(query, parameters, unitOfWork.Transaction)).First();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Plasiyerler entity)
        {
            try
            {
                int f = 0;
                var query = "UpdatePlasiyerlerDetails";
                var parameters = new DynamicParameters();
                parameters.Add(@"@PLA_ID", entity.PLA_ID, DbType.Int32);
                parameters.Add(@"@USR_ID", entity.USR_ID, DbType.Int32);
                parameters.Add(@"@CDATE", entity.CDATE, DbType.DateTime);
                parameters.Add(@"@CUSR_ID", entity.CUSR_ID, DbType.Int32);
                parameters.Add(@"@UDATE", entity.UDATE, DbType.DateTime);
                parameters.Add(@"@PLADI", entity.PLADI, DbType.String);
                parameters.Add(@"@PLSOYADI", entity.PLSOYADI, DbType.String);
                parameters.Add(@"@PLTEL", entity.PLTEL, DbType.String);
                parameters.Add(@"@PLEMAIL", entity.PLEMAIL, DbType.String);


                f = await unitOfWork.Connection.ExecuteAsync(query, parameters, unitOfWork.Transaction,
   commandType: CommandType.StoredProcedure);
                if (f > 0) return true;


            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
            return false;
        }

    }
}


