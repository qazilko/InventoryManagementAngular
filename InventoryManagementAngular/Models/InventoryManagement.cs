namespace InventoryManagementAngular.Models
{
    public class InventoryManagement
    {
        public int? Id
        {
            get; set;
        }
        public int? ItemId
        {
            get; set;
        }
        public string ItemQuantity
        {
            get; set;
        }
        public string ItemDate
        {
            get; set;
        }
        public int SupplierId
        {
            get; set;
        }
        public int ItemType
        {
            get; set;
        }
        public string BrandName
        {
            get; set;
        }
        public string CostPrice
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
    }
}
