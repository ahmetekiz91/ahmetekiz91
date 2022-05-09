

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using DBModel.Utility;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{

    public class CARIGRUPLARServices : ICARIGRUPLARServices, IDisposable
    {
        private ICARIGRUPLARRepository _CARIGRUPLARRepository;
        public IUnitOfWork unitOfWork = null;
        public IConfiguration configuration;

        public  CARIGRUPLARServices(ICARIGRUPLARRepository _CARIGRUPLARRepository)
        {
            this._CARIGRUPLARRepository = _CARIGRUPLARRepository;
        }
   
        public void Dispose()
        {
           
        }
     

        public async Task<bool> CreateCARIGRUPLARAsync(CARIGRUPLAR model)
        {

            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    this._CARIGRUPLARRepository = new CARIGRUPLARRepository(unitOfWork, configuration);
                    bool res = await _CARIGRUPLARRepository.CreateAsync(model);
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

        public async Task<bool> DeleteCARIGRUPLARAsync(int ID)
        {
            return await _CARIGRUPLARRepository.DeleteAsync(ID);
        }

        public async Task<List<CARIGRUPLAR>> GetCARIGRUPLAR()
        {
            List<CARIGRUPLAR> list = new List<CARIGRUPLAR>();
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    this._CARIGRUPLARRepository = new CARIGRUPLARRepository(unitOfWork, configuration);
                    list = await _CARIGRUPLARRepository.GetAllAsync();
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    return null;
                }
            }
            return list;
        }

        public async Task<CARIGRUPLAR> GetCARIGRUPLARById(int ID)
        {
            CARIGRUPLAR list = new CARIGRUPLAR();
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    this._CARIGRUPLARRepository = new CARIGRUPLARRepository(unitOfWork, configuration);
                    list = await _CARIGRUPLARRepository.GetByIdAsync(ID);
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    return null;
                }
            }
            return list; 
        }

        public async Task<bool> UpdateCARIGRUPLARAsync(CARIGRUPLAR model)
        {
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    this._CARIGRUPLARRepository = new CARIGRUPLARRepository(unitOfWork, configuration);
                    bool res = await _CARIGRUPLARRepository.UpdateAsync(model);
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