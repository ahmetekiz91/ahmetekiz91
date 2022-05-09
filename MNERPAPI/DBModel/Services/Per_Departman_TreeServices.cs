

using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Services
{
    public class Per_Departman_TreeServices : IPer_Departman_TreeServices
    {
        private readonly IPer_Departman_TreeRepository _Per_Departman_TreeRepository;

        public  Per_Departman_TreeServices(IPer_Departman_TreeRepository _Per_Departman_TreeRepository)
        {
            this._Per_Departman_TreeRepository = _Per_Departman_TreeRepository;
        }

        public async Task<bool> CreatePer_Departman_TreeAsync(Per_Departman_Tree model)
        {
            return await _Per_Departman_TreeRepository.CreateAsync(model);
        }

        public async Task<bool> DeletePer_Departman_TreeAsync(int ID)
        {
            return await _Per_Departman_TreeRepository.DeleteAsync(ID);
        }

        public async Task<List<Per_Departman_Tree>> GetPer_Departman_Tree()
        {
            return await _Per_Departman_TreeRepository.GetAllAsync();
        }

        public async Task<Per_Departman_Tree> GetPer_Departman_TreeById(int ID)
        {
            return await _Per_Departman_TreeRepository.GetByIdAsync(ID);
        }

        public async Task<bool> UpdatePer_Departman_TreeAsync(Per_Departman_Tree model)
        {
            return await _Per_Departman_TreeRepository.UpdateAsync(model);
        }
    }


}



