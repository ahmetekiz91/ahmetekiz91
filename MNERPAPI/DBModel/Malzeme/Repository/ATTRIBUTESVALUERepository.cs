
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
    public class ATTRIBUTESVALUERepository : BaseRepository, IRepository.IATTRIBUTESVALUERepository
    {

        public ATTRIBUTESVALUERepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<bool> CreateAsync(ATTRIBUTESVALUE entity)
        {

            try
            {
                var query = "AddATTRIBUTESVALUE";

                var parameters = new DynamicParameters();
                parameters.Add("@ATT_ID", entity.ATT_ID, DbType.Int32);
                parameters.Add("@CDATE", entity.CDATE, DbType.DateTime);
                parameters.Add("@VALUE", entity.VALUE, DbType.String);
                parameters.Add("@BIRIM_ID", entity.BIRIM_ID, DbType.Int32);
                parameters.Add("@ACTIVE", entity.ACTIVE, DbType.Int32);


                using (var connection = CreateConnection())
                {
                    var res = (await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure)); return true;
                }
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
        }

        public async Task<bool> DeleteAsync(object ID)
        {
            try
            {
                var query = "DeleteATTRIBUTESVALUE";

                var parameters = new DynamicParameters();
                parameters.Add("ID", (ID == null ? 0 : Convert.ToInt32(ID)), DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.QueryFirstOrDefaultAsync<ATTRIBUTESVALUE>(query, parameters, commandType: CommandType.StoredProcedure));
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<ATTRIBUTESVALUE>> GetAllAsync()
        {
            try
            {

                var query = "getAllATTRIBUTESVALUE";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<ATTRIBUTESVALUE>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<AttributeValuesDTO>> GetAllDTOAsync()
        {
            try
            {
                var query = @"SELECT av.[ID]
                ,av.[ATT_ID]
                ,av.[VALUE]
                ,av.[CDATE]
                ,av.[ACTIVE]
                ,av.[BIRIM_ID],b.BRM_ADI'BIRIM_ADI',a.VIEWNAME
                 FROM [ATTRIBUTESVALUE] av 
                 left join BIRIMLER b on b.BRM_ID=av.BIRIM_ID
                 inner join ATTRIBUTES a on a.ATT_ID=av.ATT_ID ";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<AttributeValuesDTO>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<ATTRIBUTES>> ddl_Attribute()
        {
            try
            {
                var query = @"  Select 0 as [ATT_ID],' Seçiniz' as [VIEWNAME] union all Select [ATT_ID],[VIEWNAME] from [ATTRIBUTES]";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<ATTRIBUTES>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


        public async Task<AttributeValuesDTO> GetByIdDTOAsync(int id)
        {
            try
            {

                var query =@" SELECT av.[ID]
                , av.[ATT_ID]
                ,av.[VALUE]
                ,av.[CDATE]
                ,av.[ACTIVE]
                ,av.[BIRIM_ID],b.BRM_ADI'BIRIM_ADI',a.VIEWNAME
                 FROM[ATTRIBUTESVALUE] av
                left join BIRIMLER b on b.BRM_ID = av.BIRIM_ID
                 inner join ATTRIBUTES a on a.ATT_ID = av.ATT_ID  WHERE av.ID = @ID";
                var parameters = new DynamicParameters();
                parameters.Add("ID", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<AttributeValuesDTO>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(ATTRIBUTESVALUE entity)
        {
            try
            {

                var query = "UpdateATTRIBUTESVALUEDetails";
                var parameters = new DynamicParameters();
                parameters.Add("@ID", entity.ID, DbType.Int32);
                parameters.Add("@ATT_ID", entity.ATT_ID, DbType.Int32);
                parameters.Add("@CDATE", entity.CDATE, DbType.DateTime);
                parameters.Add("@VALUE", entity.VALUE, DbType.String);
                parameters.Add("@BIRIM_ID", entity.BIRIM_ID, DbType.Int32);
                parameters.Add("@ACTIVE", entity.ACTIVE, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var res = (await connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure));
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
        }

        public Task<ATTRIBUTESVALUE> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}


