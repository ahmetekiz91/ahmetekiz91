
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IMuhasebe_HesaplariServices
    {

        public Task<List<Muhasebe_Hesaplari>> GetMuhasebe_Hesaplari();
        
        public Task<Muhasebe_Hesaplari> GetMuhasebe_HesaplariById(int id);
        
        public Task<bool> CreateMuhasebe_HesaplariAsync(Muhasebe_Hesaplari model);
        
        public Task<bool> UpdateMuhasebe_HesaplariAsync(Muhasebe_Hesaplari model);
 
        public Task<bool> DeleteMuhasebe_HesaplariAsync(int ID);   
    }
}


