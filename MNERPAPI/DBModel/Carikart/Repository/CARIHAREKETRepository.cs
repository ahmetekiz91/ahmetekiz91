
using Dapper;
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

    public class CARIHAREKETRepository : BaseRepository, IRepository.ICARIHAREKETRepository
    {     
        private readonly IConfiguration _configuration;
        public IUnitOfWork unitOfWork = null;

        public CARIHAREKETRepository(IConfiguration configuration) :   base(configuration)
        {
            
        }

        public CARIHAREKETRepository(IUnitOfWork unitOfWork, IConfiguration configuration) :  base(configuration)
        {
            this.unitOfWork = unitOfWork;
        }
      
        protected IDbConnection CreateConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("ConnStr"));
        }
       
        public bool CreateAsync(CARIHAREKET entity)
        {
            try
            {
                var query = "AddCARIHAREKET";
                var parameters = new DynamicParameters();
                if (entity.CDATE!=null) parameters.Add("@CDATE", entity.CDATE);
                if (entity.BORC != null) parameters.Add("@BORC", entity.BORC);
                if (entity.ALACAK != null) parameters.Add("@ALACAK", entity.ALACAK);
                if (entity.GIRISMI != null) parameters.Add("@GIRISMI", entity.GIRISMI);
                if (entity.CIKISMI != null) parameters.Add("@CIKISMI", entity.CIKISMI);
                if (entity.FTUR_ID != null) parameters.Add("@FTUR_ID", entity.FTUR_ID);
                if (entity.TUTAR != null) parameters.Add("@TUTAR", entity.TUTAR);
                if (entity.DOV_ID != null) parameters.Add("@DOV_ID", entity.DOV_ID);
                if (entity.CEKSENNO != null) parameters.Add("@CEKSENNO", entity.CEKSENNO);
                if (entity.TAHNO != null) parameters.Add("@TAHNO", entity.TAHNO);
                if (entity.ISLEMTARIHI != null) parameters.Add("@ISLEMTARIHI", entity.ISLEMTARIHI);
                if (entity.CARI_ID != null) parameters.Add("@CARI_ID", entity.CARI_ID);
                if (entity.FISIDREF != null) parameters.Add("@FISIDREF", entity.FISIDREF);
                if (entity.FISIDREF2 != null) parameters.Add("@FISIDREF2", entity.FISIDREF2);
                if (entity.FISIDREF3 != null) parameters.Add("@FISIDREF3", entity.FISIDREF3);
                if (entity.ACIKLAMA != null) parameters.Add("@ACIKLAMA", entity.ACIKLAMA);
                if (entity.LDOV_ID != null) parameters.Add("@LDOV_ID", entity.LDOV_ID);
                if (entity.KUR1 != null) parameters.Add("@KUR1", entity.KUR1);
                if (entity.KUR2 != null) parameters.Add("@KUR2", entity.KUR2);
                if (entity.STOPAJORAN != null) parameters.Add("@STOPAJORAN", entity.STOPAJORAN);
                if (entity.STOPAJTUTAR != null) parameters.Add("@STOPAJTUTAR", entity.STOPAJTUTAR);
                if (entity.FONPAYIORAN != null) parameters.Add("@FONPAYIORAN", entity.FONPAYIORAN);
                if (entity.FONPAYITUTAR != null) parameters.Add("@FONPAYITUTAR", entity.FONPAYITUTAR);
                if (entity.BRKDVORAN != null) parameters.Add("@BRKDVORAN", entity.BRKDVORAN);
                if (entity.BRKDVTUTAR != null) parameters.Add("@BRKDVTUTAR", entity.BRKDVTUTAR);
                if (entity.NET != null) parameters.Add("@NET", entity.NET);
                if (entity.BRUT != null) parameters.Add("@BRUT", entity.BRUT);
                if (entity.KESTUTAR != null) parameters.Add("@KESTUTAR", entity.KESTUTAR);
                if (entity.TOPLAM != null) parameters.Add("@TOPLAM", entity.TOPLAM);
                if (entity.BNK_ID != null) parameters.Add("@BNK_ID", entity.BNK_ID);
                if (entity.FIS_ID != null) parameters.Add("@FIS_ID", entity.FIS_ID);
                if (entity.TRANSACTION_ID != null) parameters.Add("@TRANSACTION_ID", entity.TRANSACTION_ID);
                    unitOfWork.Connection.Execute(query, parameters, unitOfWork.Transaction,commandType: CommandType.StoredProcedure);

                return true;
            }
            catch (Exception ex)
            {

                throw new NotImplementedException("Cari Hareket Hata");
            }
        }
     
        public async Task<bool> DeleteAsync(object CARI_HAR_ID)
        {

            try
            {
                var query = "DeleteCARIHAREKET";

                var parameters = new DynamicParameters();
                parameters.Add("CARI_HAR_ID", (CARI_HAR_ID == null ? 0 : Convert.ToInt32(CARI_HAR_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<CARIHAREKET>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        
        public async Task<List<CARIHAREKET>> GetAllAsync(int FIS_ID)
        {
            try
            {
                var query = " SELECT * FROM CARIHAREKET WHERE FIS_ID = @FIS_ID";
                var parameters = new DynamicParameters();
                parameters.Add("FIS_ID", FIS_ID, DbType.Int32);
                return  (await unitOfWork.Connection.QueryAsync<CARIHAREKET>(query, parameters, unitOfWork.Transaction)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<CARIHAREKET>> GetAllAsync()
        {
            try
            {

                var query = "getCARIHAREKET";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<CARIHAREKET>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<CARIHAREKET> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM CARIHAREKET WHERE CARI_HAR_ID = @CARI_HAR_ID";
                var parameters = new DynamicParameters();
                parameters.Add("CARI_HAR_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<CARIHAREKET>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(CARIHAREKET entity)
        {
            try
            {
                var query = "UpdateCARIHAREKETDetails";

                var parameters = new DynamicParameters();
                if (entity.CARI_HAR_ID != null) parameters.Add("@CARI_HAR_ID", entity.CARI_HAR_ID);
                if (entity.CDATE != null) parameters.Add("@CDATE", entity.CDATE);
                if (entity.BORC != null) parameters.Add("@BORC", entity.BORC);
                if (entity.ALACAK != null) parameters.Add("@ALACAK", entity.ALACAK);
                if (entity.GIRISMI != null) parameters.Add("@GIRISMI", entity.GIRISMI);
                if (entity.CIKISMI != null) parameters.Add("@CIKISMI", entity.CIKISMI);
                if (entity.FTUR_ID != null) parameters.Add("@FTUR_ID", entity.FTUR_ID);
                if (entity.TUTAR != null) parameters.Add("@TUTAR", entity.TUTAR);
                if (entity.DOV_ID != null) parameters.Add("@DOV_ID", entity.DOV_ID);
                if (entity.CEKSENNO != null) parameters.Add("@CEKSENNO", entity.CEKSENNO);
                if (entity.TAHNO != null) parameters.Add("@TAHNO", entity.TAHNO);
                if (entity.ISLEMTARIHI != null) parameters.Add("@ISLEMTARIHI", entity.ISLEMTARIHI);
                if (entity.CARI_ID != null) parameters.Add("@CARI_ID", entity.CARI_ID);
                if (entity.FISIDREF != null) parameters.Add("@FISIDREF", entity.FISIDREF);
                if (entity.FISIDREF2 != null) parameters.Add("@FISIDREF2", entity.FISIDREF2);
                if (entity.FISIDREF3 != null) parameters.Add("@FISIDREF3", entity.FISIDREF3);
                if (entity.ACIKLAMA != null) parameters.Add("@ACIKLAMA", entity.ACIKLAMA);
                if (entity.LDOV_ID != null) parameters.Add("@LDOV_ID", entity.LDOV_ID);
                if (entity.KUR1 != null) parameters.Add("@KUR1", entity.KUR1);
                if (entity.KUR2 != null) parameters.Add("@KUR2", entity.KUR2);
                if (entity.STOPAJORAN != null) parameters.Add("@STOPAJORAN", entity.STOPAJORAN);
                if (entity.STOPAJTUTAR != null) parameters.Add("@STOPAJTUTAR", entity.STOPAJTUTAR);
                if (entity.FONPAYIORAN != null) parameters.Add("@FONPAYIORAN", entity.FONPAYIORAN);
                if (entity.FONPAYITUTAR != null) parameters.Add("@FONPAYITUTAR", entity.FONPAYITUTAR);
                if (entity.BRKDVORAN != null) parameters.Add("@BRKDVORAN", entity.BRKDVORAN);
                if (entity.BRKDVTUTAR != null) parameters.Add("@BRKDVTUTAR", entity.BRKDVTUTAR);
                if (entity.NET != null) parameters.Add("@NET", entity.NET);
                if (entity.BRUT != null) parameters.Add("@BRUT", entity.BRUT);
                if (entity.KESTUTAR != null) parameters.Add("@KESTUTAR", entity.KESTUTAR);
                if (entity.TOPLAM != null) parameters.Add("@TOPLAM", entity.TOPLAM);
                if (entity.BNK_ID != null) parameters.Add("@BNK_ID", entity.BNK_ID);
                if (entity.FIS_ID != null) parameters.Add("@FIS_ID", entity.FIS_ID);
                if (entity.TRANSACTION_ID != null) parameters.Add("@TRANSACTION_ID", entity.TRANSACTION_ID);
                int a=unitOfWork.Connection.Execute(query, parameters, unitOfWork.Transaction, commandType: CommandType.StoredProcedure);
                if (a > 0) return true;
               
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

        Task<bool> IRepository<CARIHAREKET>.CreateAsync(CARIHAREKET entity)
        {
            throw new NotImplementedException();
        }
    }
}