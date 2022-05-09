
using DBModel;
using DBModel.Model;
using DBModel.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FINANS.IRepository
{
    public interface ICARIFISRepository : IDisposable, IRepository<CARIFISDTO>
    {
        Task<List<CARIFISDTO>> GetById(int ID);


    }
}

