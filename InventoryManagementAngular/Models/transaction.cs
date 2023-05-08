using System.ComponentModel.DataAnnotations;

namespace InventoryManagementAngular.Models
{
    public class transaction
    {
        
        public int? Id
        {
            get; set;
        }
        public DateTime? Date { get; set; }
       
        public decimal Credit
        {
            get; set;
        }
        public decimal Debit
        {
            get; set;
        }
        public decimal BankCharges
        {
            get; set;
        }
        public decimal BalAmount
        {
            get; set;
        }
        public int RegId { get; set; }
    }
}
