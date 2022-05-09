
using Dapper;
using DBModel.DTO;
using DBModel.IRepository;
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
    public class CARIKARTRepository : BaseRepository, IDisposable, IRepository.ICARIKARTRepository
    {

        public IUnitOfWork unitOfWork = null;
        private readonly IConfiguration _configuration;


        public CARIKARTRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public CARIKARTRepository(IUnitOfWork unitOfWork, IConfiguration configuration) : base(configuration)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(CARIKART entity)
        {
                try
                {
                    var query = "AddCARIKART";
                    var parameters = new DynamicParameters();
                    parameters.Add("@CARI_KODU", entity.CARI_KODU, DbType.String);
                    parameters.Add("@CARI_UNVAN", entity.CARI_UNVAN, DbType.String);
                    parameters.Add("@ALICI", entity.ALICI, DbType.Int32);
                    parameters.Add("@SATICI", entity.SATICI, DbType.Int32);
                    parameters.Add("@CDATE", entity.CDATE, DbType.DateTime);
                    parameters.Add("@CUSR_ID", entity.CUSR_ID, DbType.Int32);
                    parameters.Add("@SPECODE1", entity.SPECODE1, DbType.String);
                    parameters.Add("@SPECODE2", entity.SPECODE2, DbType.String);
                    parameters.Add("@SPECODE3", entity.SPECODE3, DbType.String);
                    parameters.Add("@SPECODE4", entity.SPECODE4, DbType.String);
                    parameters.Add("@SPECODE5", entity.SPECODE5, DbType.String);
                    parameters.Add("@SPECODE6", entity.SPECODE6, DbType.String);
                    parameters.Add("@SPECODE7", entity.SPECODE7, DbType.String);
                    parameters.Add("@TEL1", entity.TEL1, DbType.String);
                    parameters.Add("@TEL2", entity.TEL2, DbType.String);
                    parameters.Add("@TEL3", entity.TEL3, DbType.String);
                    parameters.Add("@EMAIL", entity.EMAIL, DbType.String);
                    parameters.Add("@FAX", entity.FAX, DbType.String);
                    parameters.Add("@FAX2", entity.FAX2, DbType.String);
                    parameters.Add("@ULKE_ID", entity.ULKE_ID, DbType.Int32);
                    parameters.Add("@PLASIYER_ID", entity.PLASIYER_ID, DbType.Int32);
                    parameters.Add("@VERGINO", entity.VERGINO, DbType.String);
                    parameters.Add("@VERGIDAIRESI", entity.VERGIDAIRESI, DbType.String);
                    parameters.Add("@WEB", entity.WEB, DbType.String);
                    parameters.Add("@ACTIVE", entity.ACTIVE, DbType.Int32);
                    parameters.Add("@GRUPID", entity.GRUPID, DbType.Int32);
                    var r = await unitOfWork.Connection.ExecuteAsync(query, parameters, unitOfWork.Transaction,
                        commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    
                    return false;
                }

        }

        public async Task<bool> DeleteAsync(object Cari_ID)
        {
            try
            {
                var query = "DeleteCARIKART";

                var parameters = new DynamicParameters();
                parameters.Add("@CARI_ID", (Cari_ID == null ? 0 : Convert.ToInt32(Cari_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<CARIKART>(query, parameters,
                        commandType: CommandType.StoredProcedure));
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

        }

        public async Task<List<CARIKART>> GetAllAsync()
        {
            List<CARIKART> list = new List<CARIKART>();
            try
            {
               
             
                    var query = "getAllCARIKART";

                    var parameters = new DynamicParameters();
                    list = (await unitOfWork.Connection.QueryAsync<CARIKART>(query, parameters, unitOfWork.Transaction)).ToList();
              
                   
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return list;
        }
        public async Task<List<CARIKARTDTO>> GetAllDTOAsync()
        {
            List<CARIKARTDTO> list = new List<CARIKARTDTO>();
            try
            {
                var query = @"SELECT 
       c.[CARI_ID]
      ,c.[CARI_KODU]
      ,c.[CARI_UNVAN]
      ,c.[ALICI]
      ,c.[SATICI]
      ,c.[CDATE]
      ,c.[CUSR_ID]
      ,c.[SPECODE1]
      ,c.[SPECODE2]
      ,c.[SPECODE3]
      ,c.[SPECODE4]
      ,c.[SPECODE5]
      ,c.[SPECODE6]
      ,c.[SPECODE7]
      ,c.[TEL1]
      ,c.[TEL2]
      ,c.[TEL3]
      ,c.[EMAIL]
      ,c.[FAX]
      ,c.[FAX2]
      ,c.[ULKE_ID]
      ,c.[PLASIYER_ID]
      ,c.[VERGINO]
      ,c.[VERGIDAIRESI]
      ,c.[WEB]
      ,c.[GRUPID]
      ,c.[ACTIVE],cg.ADI 'GRUPADI',p.PLADI as PLASIYER_ADI,u.Ulke_Adi as ULKE_ADI
  FROM [CARIKART] c
  left join CARIGRUPLAR cg on cg.CARI_GRUP_ID=c.GRUPID
  left join Plasiyerler p on p.PLA_ID=c.PLASIYER_ID
  left join Ulkeler u on u.Ulke_ID=c.ULKE_ID ";
                var parameters = new DynamicParameters();
                list = (await unitOfWork.Connection.QueryAsync<CARIKARTDTO>(query, parameters, unitOfWork.Transaction)).ToList();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return list;
        }
        public async Task<CARIKART> GetByIdAsync(int id)
        {
            try
            {

                var query = " SELECT * FROM CARIKART WHERE CARI_ID = @CARI_ID";
                var parameters = new DynamicParameters();
                parameters.Add("Cari_ID", id, DbType.Int32);
                return (await unitOfWork.Connection.QueryAsync<CARIKART>(query, parameters, unitOfWork.Transaction)).First();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<CARIKARTDTO> GetByIdDTOAsync(int ID)
        {
            try
            {

                var query = @" SELECT 
       c.[CARI_ID]
      ,c.[CARI_KODU]
      ,c.[CARI_UNVAN]
      ,c.[ALICI]
      ,c.[SATICI]
      ,c.[CDATE]
      ,c.[CUSR_ID]
      ,c.[SPECODE1]
      ,c.[SPECODE2]
      ,c.[SPECODE3]
      ,c.[SPECODE4]
      ,c.[SPECODE5]
      ,c.[SPECODE6]
      ,c.[SPECODE7]
      ,c.[TEL1]
      ,c.[TEL2]
      ,c.[TEL3]
      ,c.[EMAIL]
      ,c.[FAX]
      ,c.[FAX2]
      ,c.[ULKE_ID]
      ,c.[PLASIYER_ID]
      ,c.[VERGINO]
      ,c.[VERGIDAIRESI]
      ,c.[WEB]
      ,c.[GRUPID]
      ,c.[ACTIVE],cg.ADI 'GRUPADI',p.PLADI as PLASIYER_ADI,u.Ulke_Adi as ULKE_ADI
  FROM [CARIKART] c
  left join CARIGRUPLAR cg on cg.CARI_GRUP_ID=c.GRUPID
  left join Plasiyerler p on p.PLA_ID=c.PLASIYER_ID
  left join Ulkeler u on u.Ulke_ID=c.ULKE_ID
  WHERE c.CARI_ID = @CARI_ID";
                var parameters = new DynamicParameters();
                parameters.Add("CARI_ID", ID, DbType.Int32);
                return (await unitOfWork.Connection.QueryAsync<CARIKARTDTO>(query, parameters, unitOfWork.Transaction)).First();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(CARIKART entity)
        {
            try
            {
                var query = "UpdateCARIKARTDetails";

                var parameters = new DynamicParameters();
                parameters.Add("@CARI_KODU", entity.CARI_KODU, DbType.String);
                parameters.Add("@CARI_UNVAN", entity.CARI_UNVAN, DbType.String);
                parameters.Add("@ALICI", entity.ALICI, DbType.Int32);
                parameters.Add("@SATICI", entity.SATICI, DbType.Int32);
                parameters.Add("@CUSR_ID", entity.CUSR_ID, DbType.Int32);
                parameters.Add("@CDATE", entity.CDATE, DbType.DateTime);
                parameters.Add("@SPECODE1", entity.SPECODE1, DbType.String);
                parameters.Add("@SPECODE2", entity.SPECODE2, DbType.String);
                parameters.Add("@SPECODE3", entity.SPECODE3, DbType.String);
                parameters.Add("@SPECODE4", entity.SPECODE4, DbType.String);
                parameters.Add("@SPECODE5", entity.SPECODE5, DbType.String);
                parameters.Add("@SPECODE6", entity.SPECODE6, DbType.String);
                parameters.Add("@SPECODE7", entity.SPECODE7, DbType.String);
                parameters.Add("@TEL1", entity.TEL1, DbType.String);
                parameters.Add("@TEL2", entity.TEL2, DbType.String);
                parameters.Add("@TEL3", entity.TEL3, DbType.String);
                parameters.Add("@EMAIL", entity.EMAIL, DbType.String);
                parameters.Add("@FAX", entity.FAX, DbType.String);
                parameters.Add("@FAX2", entity.FAX2, DbType.String);
                parameters.Add("@ULKE_ID", entity.ULKE_ID, DbType.Int32);
                parameters.Add("@PLASIYER_ID", entity.PLASIYER_ID, DbType.Int32);
                parameters.Add("@VERGINO", entity.VERGINO, DbType.String);
                parameters.Add("@VERGIDAIRESI", entity.VERGIDAIRESI, DbType.String);
                parameters.Add("@WEB", entity.WEB, DbType.String);
                parameters.Add("@ACTIVE", entity.ACTIVE, DbType.Int32);
                parameters.Add("@GRUPID", entity.GRUPID, DbType.Int32);
                parameters.Add("@CARI_ID", entity.CARI_ID, DbType.Int32);

                //using (var connection = CreateConnection())
                //{
                //    var res = (await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure));
                //    return true;
                //}
                var r = await unitOfWork.Connection.ExecuteAsync(query, parameters, unitOfWork.Transaction, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
        }

     
    }
}


