using Dapper;
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
    public class PlasiyerlerServices : IPlasiyerlerServices
    {
        private  IPlasiyerlerRepository _PlasiyerlerRepository;
        public IUnitOfWork unitOfWork = null;
        public IConfiguration configuration;

        public PlasiyerlerServices(IPlasiyerlerRepository _PlasiyerlerRepository)
        {
            this._PlasiyerlerRepository = _PlasiyerlerRepository;
        }

        public async Task<bool> CreatePlasiyerlerAsync(Plasiyerler model)
        {
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    this._PlasiyerlerRepository = new PlasiyerlerRepository(unitOfWork, configuration);
                    bool res = await _PlasiyerlerRepository.CreateAsync(model);
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

        public async Task<bool> DeletePlasiyerlerAsync(int ID)
        {
            return await _PlasiyerlerRepository.DeleteAsync(ID);
        }

        public void Dispose()
        {
            
        }

        public async Task<List<Plasiyerler>> GetPlasiyerler()
        {
            List<Plasiyerler> list = new List<Plasiyerler>();
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    this._PlasiyerlerRepository = new PlasiyerlerRepository(unitOfWork, configuration);
                    list = await _PlasiyerlerRepository.GetAllAsync();
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    return null;
                }
            }
            return list;
        }

        public async Task<Plasiyerler> GetPlasiyerlerById(int ID)
        {
            Plasiyerler list = new Plasiyerler();
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    this._PlasiyerlerRepository = new PlasiyerlerRepository(unitOfWork, configuration);
                    list = await _PlasiyerlerRepository.GetByIdAsync(ID);
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    return null;
                }
            }
            return list;
        }

        public async Task<bool> UpdatePlasiyerlerAsync(Plasiyerler model)
        {
            using (DalSession dalSession = new DalSession())
            {
                this.unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {

                    this._PlasiyerlerRepository = new PlasiyerlerRepository(unitOfWork, configuration);

                    bool res = await _PlasiyerlerRepository.UpdateAsync(model);
                    if (res)
                    {
                        unitOfWork.Commit();
                        return true;
                    }

                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
              
                }
            }
            return false;
        }
    }
}