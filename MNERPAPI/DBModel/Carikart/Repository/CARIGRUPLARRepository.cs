
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
    public class CARIGRUPLARRepository : BaseRepository, IDisposable, IRepository.ICARIGRUPLARRepository
    {
        public IUnitOfWork unitOfWork = null;
        private readonly IConfiguration _configuration;


        public CARIGRUPLARRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public CARIGRUPLARRepository(IUnitOfWork unitOfWork, IConfiguration configuration) : base(configuration)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Dispose()
        {

        }

        public async Task<bool> CreateAsync(CARIGRUPLAR entity)
        {
            int f = 0;
            try
            {
                var query = "AddCARIGRUPLAR";
                var parameters = new DynamicParameters(); parameters.Add(@"CARI_GRUP_ID", entity.CARI_GRUP_ID);
                parameters.Add(@"ADI", entity.ADI);
                parameters.Add(@"KODU", entity.KODU);
                parameters.Add(@"CDATE", entity.CDATE);
                parameters.Add(@"CUSR_ID", entity.CUSR_ID);
                parameters.Add(@"UDATE", entity.UDATE);
                parameters.Add(@"UUSR_ID", entity.UUSR_ID);


                f = unitOfWork.Connection.QuerySingle<int>(query, parameters, unitOfWork.Transaction, commandType: CommandType.StoredProcedure);
                if (f > 0) return true;
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
            return false;
        }

        public async Task<bool> DeleteAsync(object CARI_GRUP_ID)
        {
            try
            {
                int f = 0;
                var query = "DeleteCARIGRUPLAR";

                var parameters = new DynamicParameters();
                parameters.Add("CARI_GRUP_ID", (CARI_GRUP_ID == null ? 0 : Convert.ToInt32(CARI_GRUP_ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<CARIGRUPLAR>(query, parameters));
                    return true;
                }
            }
            catch (Exception ex)
            {
                
            }
            return false;
        }

        public async Task<List<CARIGRUPLAR>> GetAllAsync()
        {
            List<CARIGRUPLAR> list = new List<CARIGRUPLAR>();
            try
            {
               
                var query = "SELECT * FROM CARIGRUPLAR";
                list = (await unitOfWork.Connection.QueryAsync<CARIGRUPLAR>(query,  unitOfWork.Transaction)).ToList();

            }
            catch (Exception ex)
            {
                return null;
            }
            return list;
        }

        public async Task<CARIGRUPLAR> GetByIdAsync(int id)
        {
            CARIGRUPLAR list = new CARIGRUPLAR();
            try
            {
               
                var query = " SELECT * FROM CARIGRUPLAR WHERE CARI_GRUP_ID = @CARI_GRUP_ID";
                var parameters = new DynamicParameters();
                parameters.Add("CARI_GRUP_ID", id, DbType.Int32);
                list = (await unitOfWork.Connection.QueryAsync<CARIGRUPLAR>(query, parameters, unitOfWork.Transaction)).First();

            
            }
            catch (Exception ex)
            {
                return null;
            }
            return list;
        }

        public async Task<bool> UpdateAsync(CARIGRUPLAR entity)
        {
            try
            {
                int f = 0;
                var query = "UpdateCARIGRUPLARDetails";
                var parameters = new DynamicParameters(); parameters.Add(@"CARI_GRUP_ID", entity.CARI_GRUP_ID);
                parameters.Add(@"ADI", entity.ADI);
                parameters.Add(@"KODU", entity.KODU);
                parameters.Add(@"CDATE", entity.CDATE);
                parameters.Add(@"CUSR_ID", entity.CUSR_ID);
                parameters.Add(@"UDATE", entity.UDATE);
                parameters.Add(@"UUSR_ID", entity.UUSR_ID);


                f = unitOfWork.Connection.QuerySingle<int>(query, parameters, unitOfWork.Transaction, commandType: CommandType.StoredProcedure);
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


