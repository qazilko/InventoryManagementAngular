using InventoryManagementAngular.Models;

namespace InventoryManagementAngular.Repository
{
    public interface IItemRepository
    {
        public IEnumerable<Item> GetItems();
       
    }
}
