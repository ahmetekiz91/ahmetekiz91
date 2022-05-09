
using Dapper;
using DBModel.IRepository;
using DBModel.Model;
using DBModel.Utility;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    //Unit of work kullanırken birden fazla constructer olacak ve mutlaka IDisposable kullanılacak
    public class FISLERRepository : IDisposable, IFISLERRepository
    {
        private readonly IConfiguration _configuration;
      
        public IUnitOfWork unitOfWork = null;

        public FISLERRepository(IUnitOfWork unitOfWork) 
        {
            this.unitOfWork = unitOfWork;
        }

        public FISLERRepository()
        {
        }

        public FISLERRepository(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            this.unitOfWork = unitOfWork;
        }

        protected IDbConnection CreateConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("ConnStr"));
        }
      
        public int CreateAsync(FISLER entity)
        {

            var query = "AddFISLER";
            int f = 0;
            var parameters = new DynamicParameters();
            parameters.Add("@CDATE", entity.CDATE);
            parameters.Add("@CUSR_ID", entity.CUSR_ID);
            parameters.Add("@FISTARIHI", entity.FISTARIHI);
            parameters.Add("@CARIID", entity.CARIID);
            parameters.Add("@FISTURID", entity.FISTURID);
            parameters.Add("@FISREFID", entity.FISREFID);
            parameters.Add("@TEKREFID", entity.TEKREFID);
            parameters.Add("@GUID1", entity.GUID1);
            parameters.Add("@GUID2", entity.GUID2);
            parameters.Add("@FICHENO", entity.FICHENO);
            parameters.Add("@DOVIZID", entity.DOVIZID);
            parameters.Add("@ISTID", entity.ISTID);
            parameters.Add("@VADETARIHI", entity.VADETARIHI);
            parameters.Add("@ACIKLAMA", entity.ACIKLAMA);
            parameters.Add("@KASAID", entity.KASAID);
            parameters.Add("@TOPLAM", entity.TOPLAM);
            parameters.Add("@BORDRONO", entity.BORDRONO);
            parameters.Add("@BORDTAR", entity.BORDTAR);
            parameters.Add("@STATUS", entity.STATUS);
            parameters.Add("@UDATE", entity.UDATE);
            parameters.Add("@UUSR_ID", entity.UUSR_ID);
            parameters.Add("@CARIMUHKODU", entity.CARIMUHKODU);
            parameters.Add("@TRANSACTION_ID", entity.TRANSACTION_ID);

             f= unitOfWork.Connection.QuerySingle<int>(query, parameters, unitOfWork.Transaction, commandType: CommandType.StoredProcedure);
            return f;
        }

        public bool CreateAsync(FISLER entity,SqlConnection conn,SqlTransaction transaction)
        {

            try
            {

                var query = "AddFISLER";                
                var parameters = new DynamicParameters();
                using (var connection = conn)
                {
                    using (var cmd = new SqlCommand(query, conn, transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CDATE", entity.CDATE);
                        cmd.Parameters.AddWithValue("@CUSR_ID", entity.CUSR_ID);
                        cmd.Parameters.AddWithValue("@FISTARIHI", entity.FISTARIHI);
                        cmd.Parameters.AddWithValue("@CARIID", entity.CARIID);
                        cmd.Parameters.AddWithValue("@FISTURID", entity.FISTURID);
                        cmd.Parameters.AddWithValue("@FISREFID", entity.FISREFID);
                        cmd.Parameters.AddWithValue("@TEKREFID", entity.TEKREFID);
                        cmd.Parameters.AddWithValue("@GUID1", entity.GUID1);
                        cmd.Parameters.AddWithValue("@GUID2", entity.GUID2);
                        cmd.Parameters.AddWithValue("@FICHENO", entity.FICHENO);
                        cmd.Parameters.AddWithValue("@DOVIZID", entity.DOVIZID);
                        cmd.Parameters.AddWithValue("@ISTID", entity.ISTID);
                        cmd.Parameters.AddWithValue("@VADETARIHI", entity.VADETARIHI);
                        cmd.Parameters.AddWithValue("@ACIKLAMA", entity.ACIKLAMA);
                        cmd.Parameters.AddWithValue("@KASAID", entity.KASAID);
                        cmd.Parameters.AddWithValue("@TOPLAM", entity.TOPLAM);
                        cmd.Parameters.AddWithValue("@BORDRONO", entity.BORDRONO);
                        cmd.Parameters.AddWithValue("@BORDTAR", entity.BORDTAR);
                        cmd.Parameters.AddWithValue("@STATUS", entity.STATUS);
                        cmd.Parameters.AddWithValue("@UDATE", entity.UDATE);
                        cmd.Parameters.AddWithValue("@UUSR_ID", entity.UUSR_ID);
                        cmd.Parameters.AddWithValue("@CARIMUHKODU", entity.CARIMUHKODU);
                        cmd.Parameters.AddWithValue("@TRANSACTION_ID", entity.TRANSACTION_ID);
                        cmd.ExecuteNonQuery();
                        return true;
                    }

                }
               
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
        }

        public async Task<bool> DeleteAsync(object FIS_ID)
        {
            try
            {
                var query = "DeleteFISLER";
                int f = 0;
                var parameters = new DynamicParameters();
                parameters.Add("FIS_ID", (FIS_ID == null ? 0 : Convert.ToInt32(FIS_ID)), DbType.Int32);

                f = unitOfWork.Connection.QuerySingle<int>(query, parameters, unitOfWork.Transaction, commandType: CommandType.StoredProcedure);
                if (f > 0) return true;
             
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return false;
        }

        public async Task<List<FISLER>> GetAllAsync()
        {
            try
            {
                var query = "getFISLER";
                return (await unitOfWork.Connection.QueryAsync<FISLER>(query)).ToList();               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<FISLER> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM FISLER WHERE FIS_ID = @FIS_ID";
                var parameters = new DynamicParameters();
                parameters.Add("FIS_ID", id, DbType.Int32);

                return (await unitOfWork.Connection.QueryFirstOrDefaultAsync<FISLER>(query, parameters));
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(FISLER entity)
        {
            try
            {
                var query = "UpdateFISLERDetails";

                
                int f = 0;
                var parameters = new DynamicParameters();
                parameters.Add("@CDATE", entity.CDATE);
                parameters.Add("@CUSR_ID", entity.CUSR_ID);
                parameters.Add("@FISTARIHI", entity.FISTARIHI);
                parameters.Add("@CARIID", entity.CARIID);
                parameters.Add("@FISTURID", entity.FISTURID);
                parameters.Add("@FISREFID", entity.FISREFID);
                parameters.Add("@TEKREFID", entity.TEKREFID);
                parameters.Add("@GUID1", entity.GUID1);
                parameters.Add("@GUID2", entity.GUID2);
                parameters.Add("@FICHENO", entity.FICHENO);
                parameters.Add("@DOVIZID", entity.DOVIZID);
                parameters.Add("@ISTID", entity.ISTID);
                parameters.Add("@VADETARIHI", entity.VADETARIHI);
                parameters.Add("@ACIKLAMA", entity.ACIKLAMA);
                parameters.Add("@KASAID", entity.KASAID);
                parameters.Add("@TOPLAM", entity.TOPLAM);
                parameters.Add("@BORDRONO", entity.BORDRONO);
                parameters.Add("@BORDTAR", entity.BORDTAR);
                parameters.Add("@STATUS", entity.STATUS);
                parameters.Add("@UDATE", entity.UDATE);
                parameters.Add("@UUSR_ID", entity.UUSR_ID);
                parameters.Add("@CARIMUHKODU", entity.CARIMUHKODU);
                parameters.Add("@FIS_ID", entity.FIS_ID);
                parameters.Add("@TRANSACTION_ID", entity.TRANSACTION_ID);
                f =  unitOfWork.Connection.QuerySingle<int>(query, parameters, unitOfWork.Transaction, commandType: CommandType.StoredProcedure);
                if (f > 0) return true;

            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
            return false;
        }

        public void Dispose()
        {
          
        }

        Task<bool> IRepository<FISLER>.CreateAsync(FISLER entity)
        {
            throw new NotImplementedException();
        }
    }
}