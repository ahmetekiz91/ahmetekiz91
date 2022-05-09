
using DBModel.DTO;
using DBModel.Model;
using DBModel.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.IRepository
{
    public interface ICARIKARTRepository : IDisposable,IRepository<CARIKART>
    {
        public Task<List<CARIKARTDTO>> GetAllDTOAsync();
        public Task<CARIKARTDTO> GetByIdDTOAsync(int ID);
    }
}

