

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{

    public class TekliflerServices : ITekliflerServices
    {
        private readonly ITekliflerRepository _TekliflerRepository;

        public  TekliflerServices(ITekliflerRepository _TekliflerRepository)
        {
            this._TekliflerRepository = _TekliflerRepository;
        }

        public async Task<bool> CreateTekliflerAsync(Teklifler model)
        {
            return await _TekliflerRepository.CreateAsync(model);
        }

        /*
          using (IDbConnection conn = Connection)
          {
          using(var transaction = conn.BeginTransaction())//Begin here
          {
              var addAudit = await [YourMethod(conn)];//Inject as parameter
              if(addAudit == false)
                  transaction.Rollback();//Rollback if method call failed
              ...
              ...
              //Repeat same pattern for all method calls
              ...
              transaction.Commit();//Commit when all methods returned success
            }
           }
         */


        public async Task<bool> AddNewVersionTekliflerAsync(Teklifler model)
        {
            return await _TekliflerRepository.CreateAsync(model);
        }

        public async Task<bool> DeleteTekliflerAsync(int ID)
        {
            return await _TekliflerRepository.DeleteAsync(ID);
        }

        public async Task<List<Teklifler>> GetTeklifler()
        {
            return await _TekliflerRepository.GetAllAsync();
        }

        public async Task<Teklifler> GetTekliflerById(int ID)
        {
            return await _TekliflerRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdateTekliflerAsync(Teklifler model)
        {
            return await _TekliflerRepository.UpdateAsync(model);
        }
    }


}



