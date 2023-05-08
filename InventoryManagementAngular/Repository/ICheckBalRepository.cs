using InventoryManagementAngular.Models;

namespace InventoryManagementAngular.Repository
{
    public interface ICheckBalRepository
    {       
        public CheckBal GetCheckBalById(int Id);
        
    }
}
