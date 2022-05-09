
using DBModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Infrastruce
{
    public interface IPer_Departman_TreeServices
    {

        public Task<List<Per_Departman_Tree>> GetPer_Departman_Tree();
        
        public Task<Per_Departman_Tree> GetPer_Departman_TreeById(int id);
        
        public Task<bool> CreatePer_Departman_TreeAsync(Per_Departman_Tree model);
        
        public Task<bool> UpdatePer_Departman_TreeAsync(Per_Departman_Tree model);
 
        public Task<bool> DeletePer_Departman_TreeAsync(int ID);   
    }
}


