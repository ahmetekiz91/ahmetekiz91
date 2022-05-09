
using Dapper;
using DBModel.Model;
using DBModel.Utility;
using FINANS.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FINANS.Infrastruce
{
    public class PARA_HAREKETRepository : IDisposable,  IRepository.IPARA_HAREKETRepository
    {

        public IUnitOfWork unitOfWork = null;
        public IConfiguration configuration;
        public string mesaj = "";
        public PARA_HAREKETRepository()
        {

        }

        public PARA_HAREKETRepository(IUnitOfWork unitOfWork, out string mesaj)
        {
            this.unitOfWork = unitOfWork;
            mesaj = this.mesaj;
        }

        public PARA_HAREKETRepository(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(PARA_HAREKET entity)
        {

            try
            {

                int f = 0;
                var query = "AddPARA_HAREKET";
                var parameters = new DynamicParameters();
                parameters.Add(@"TRA_ID", entity.TRA_ID);
                parameters.Add(@"CDATE", entity.CDATE);
                parameters.Add(@"TARIH", entity.TARIH);
                parameters.Add(@"TUTAR", entity.TUTAR);
                parameters.Add(@"DOV_ID", entity.DOV_ID);
                parameters.Add(@"LDOV_ID", entity.LDOV_ID);
                parameters.Add(@"FIS_ID", entity.FIS_ID);
                parameters.Add(@"TUR_ID", entity.TUR_ID);
                parameters.Add(@"BORC", entity.BORC);
                parameters.Add(@"ALACAK", entity.ALACAK);
                parameters.Add(@"GIRIS", entity.GIRIS);
                parameters.Add(@"CIKIS", entity.CIKIS);
                parameters.Add(@"KUR1", entity.KUR1);
                parameters.Add(@"KUR2", entity.KUR2);
                parameters.Add(@"CKSN_ID", entity.CKSN_ID);
                parameters.Add(@"BNK_ID", entity.BNK_ID);
                parameters.Add(@"HSP_ID", entity.HSP_ID);
                parameters.Add(@"CARI_ID", entity.CARI_ID);
                parameters.Add(@"KASA_ID", entity.KASA_ID);
                parameters.Add(@"MSF_ID", entity.MSF_ID);
                parameters.Add(@"BORD_ID", entity.BORD_ID);
                parameters.Add(@"TRANSACTION_ID", entity.TRANSACTION_ID);
                f = unitOfWork.Connection.QuerySingle<int>(query, parameters, unitOfWork.Transaction,
                    commandType: CommandType.StoredProcedure);
                if (f > 0) return true;
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
          return false;
        }

        public async Task<bool> DeleteAsync(object TRA_ID)
        {
            try
            {
                var query = "DeletePARA_HAREKET";

                var parameters = new DynamicParameters();
                parameters.Add("TRA_ID", (TRA_ID == null ? 0 : Convert.ToInt32(TRA_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<PARA_HAREKET>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        protected SqlConnection CreateConnection()
        {

            return new SqlConnection(configuration.GetConnectionString("ConnStr"));
        }
     
        public async Task<List<PARA_HAREKET>> GetAllAsync()
        {
            try
            {

                var query = "getPARA_HAREKET";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<PARA_HAREKET>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<PARA_HAREKET> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM PARA_HAREKET WHERE TRA_ID = @TRA_ID";
                var parameters = new DynamicParameters();
                parameters.Add("TRA_ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<PARA_HAREKET>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(PARA_HAREKET entity)
        {
            try
            {
                int f = 0;
                var query = "UpdatePARA_HAREKETDetails";
                var parameters = new DynamicParameters(); parameters.Add(@"TRA_ID", entity.TRA_ID);
                parameters.Add(@"CDATE", entity.CDATE);
                parameters.Add(@"TARIH", entity.TARIH);
                parameters.Add(@"TUTAR", entity.TUTAR);
                parameters.Add(@"DOV_ID", entity.DOV_ID);
                parameters.Add(@"LDOV_ID", entity.LDOV_ID);
                parameters.Add(@"FIS_ID", entity.FIS_ID);
                parameters.Add(@"TUR_ID", entity.TUR_ID);
                parameters.Add(@"BORC", entity.BORC);
                parameters.Add(@"ALACAK", entity.ALACAK);
                parameters.Add(@"GIRIS", entity.GIRIS);
                parameters.Add(@"CIKIS", entity.CIKIS);
                parameters.Add(@"KUR1", entity.KUR1);
                parameters.Add(@"KUR2", entity.KUR2);
                parameters.Add(@"CKSN_ID", entity.CKSN_ID);
                parameters.Add(@"BNK_ID", entity.BNK_ID);
                parameters.Add(@"HSP_ID", entity.HSP_ID);
                parameters.Add(@"CARI_ID", entity.CARI_ID);
                parameters.Add(@"KASA_ID", entity.KASA_ID);
                parameters.Add(@"MSF_ID", entity.MSF_ID);
                parameters.Add(@"BORD_ID", entity.BORD_ID);
                parameters.Add(@"TRANSACTION_ID", entity.TRANSACTION_ID);


                f = unitOfWork.Connection.QuerySingle<int>(query, parameters, unitOfWork.Transaction,
                    commandType: CommandType.StoredProcedure);
                if (f > 0)
                    return true;


            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
            return false;
        }

    }
}