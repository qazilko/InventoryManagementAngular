using InventoryManagementAngular.Models;

namespace InventoryManagementAngular.Repository
{
    public interface ISupplierRepository
    {
        public IEnumerable<Supplier> GetSupplier();
        public IEnumerable<Supplier> GetSupplierByName(string SupplierName);
        public string InsertSupplier(Supplier data);
        public string UpdateSupplier(int id,Supplier data);
        public string DeleteSupplier(int id);
    }
}
