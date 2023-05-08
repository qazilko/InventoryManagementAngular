using InventoryManagementAngular.Models;

namespace InventoryManagementAngular.Repository
{
    public interface ItransactionRepository
    {
        public IEnumerable<transaction> Gettransactions();
        
        public List<transaction> GetTransactionById(int Id);
        public string InsertTransaction(transaction data);
    }
}
