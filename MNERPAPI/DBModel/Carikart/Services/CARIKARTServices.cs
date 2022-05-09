

using AutoMapper;
using DBModel.DTO;
using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using DBModel.Utility;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class CARIKARTServices : ICARIKARTServices,IDisposable
    {
        private  ICARIKARTRepository _CARIKARTRepository;
        public IUnitOfWork unitOfWork = null;
        public IConfiguration configuration;
        private readonly IMapper mapper;

        public  CARIKARTServices(ICARIKARTRepository _CARIKARTRepository, IMapper mapper)
        {
            this._CARIKARTRepository = _CARIKARTRepository;
            this.mapper = mapper;
        }

        public async Task<bool> CreateCARIKARTAsync(CARIKARTDTO model)
        {
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {

                    this._CARIKARTRepository = new CARIKARTRepository(unitOfWork, configuration);
                    CARIKART m = new CARIKART();
                    m = mapper.Map<CARIKART>(model);
                    bool res =await _CARIKARTRepository.CreateAsync(m);
                    if (res)
                    {
                        unitOfWork.Commit();
                        return true;
                    }
                  
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    return false;
                }
            }

            return false;
        }

        public async Task<bool> DeleteCARIKARTAsync(int ID)
        {
            return await _CARIKARTRepository.DeleteAsync(ID);
        }

        public void Dispose()
        {
            
        }

        public async Task<List<CARIKARTDTO>> GetCARIKART()
        {
            List<CARIKARTDTO> list = new List<CARIKARTDTO>();

            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    this._CARIKARTRepository = new CARIKARTRepository(unitOfWork, configuration);
                  
                    list = await _CARIKARTRepository.GetAllDTOAsync();
                    unitOfWork.Commit();
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    return null;
                }               
            }
            return list;
        }

        public async Task<CARIKARTDTO> GetCARIKARTById(int ID)
        {
            CARIKARTDTO list = new CARIKARTDTO();
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    this._CARIKARTRepository = new CARIKARTRepository(unitOfWork, configuration);

                    list = await _CARIKARTRepository.GetByIdDTOAsync(ID);
                    unitOfWork.Commit();
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    return null;
                }
            }
            return list;
            
        }

        public async Task<bool> UpdateCARIKARTAsync(CARIKARTDTO model)
        {
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    this._CARIKARTRepository = new CARIKARTRepository(unitOfWork, configuration);
                    CARIKART m = new CARIKART();
                    m = mapper.Map<CARIKART>(model);
                    bool res = await _CARIKARTRepository.UpdateAsync(m);
                    if (res)
                    {
                        unitOfWork.Commit();
                        return true;
                    }

                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    return false;
                }
            }

            return false;
        }
    }
}