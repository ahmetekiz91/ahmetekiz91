using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINANS.Infrastruct
{
    public interface ICARIFISService:IDisposable
    {
        public Task<List<CARIFISDTO>> GetCARIFISLAR();

        public Task<List<CARIFISDTO>> GetCARIFISLARById(int id);

        public Task<bool> CreateCARIFISLARAsync(CARIFISDTO model);

        public Task<bool> UpdateCARIFISLARAsync(CARIFISDTO model);

        public Task<bool> DeleteCARIFISLARAsync(int ID);
    }
}
